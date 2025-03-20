using System;
using System.Diagnostics;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;
using VRC.SDKBase;
using Debug = UnityEngine.Debug;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class ObjectSpawnBenchmarkTester : UdonSharpBehaviour
    {
        [SerializeField] private ObjectSpawnerBase[] _spawners;
        [SerializeField] private int _spawnPerSeconds = 100; // 1秒あたりオブジェクト配置個数
        [SerializeField] private double _stopFPS = 10; // FPSがこの値を下回ると終了
        [SerializeField] private int _testIterations = 5; // 試行回数
        [SerializeField] private int _maxSpawnCount = 1000000; // 強制終了

        private int _currentSpawnerIndex;
        private int _currentIterations;

        private int _spawnedCount; // 配置したオブジェクト数
        private float _lastSpawnTime; // 最後のスポーン時間
        private bool _isBenchmarkRunning;
        private double _stopMilliseconds;
        private float _lastLogUpdateTime;

        private DataList _results = new DataList();

        [SerializeField] private TMP_Text _testNameText;
        private bool _testNameTextExists;
        [SerializeField] private TMP_Text _logText;
        private bool _logTextExists;
        [SerializeField] private TMP_InputField _resultText;
        private bool _resultTextExists;

        [SerializeField] private bool _realTimeLog = true;

        private Stopwatch _stopwatch = new Stopwatch();
        private int _currentCacheIndex = 0;
        private double[] _elapsedTimeCache = new double[30];

        private void Start()
        {
            _testNameTextExists = Utilities.IsValid(_testNameText);
            _resultTextExists = Utilities.IsValid(_resultText);
            _logTextExists = Utilities.IsValid(_logText);

            _stopMilliseconds = 1000.0 / _stopFPS;
        }

        private void Update()
        {
            if (!_isBenchmarkRunning)
            {
                return;
            }
            
            _stopwatch.Stop();
            
            var currentSpawner = _spawners[_currentSpawnerIndex];
            var elapsedTime = _stopwatch.Elapsed.TotalMilliseconds;
            _elapsedTimeCache[_currentCacheIndex] = elapsedTime;
            _currentCacheIndex = (_currentCacheIndex + 1) % _elapsedTimeCache.Length;

            if (_maxSpawnCount <= _spawnedCount)
            {
                Debug.Log(
                    $"[SpawnBenchmark] {_spawners[_currentSpawnerIndex].PrefabName} iterations:{_currentIterations} 終了: {_spawnedCount} 個配置");
                _results[_currentSpawnerIndex].DataList.Add(_spawnedCount);
                currentSpawner.Cleanup();
                
                // テストを切り上げて次のテストに移る
                _currentIterations = _testIterations;
                NextTest();
                return;
            }

            // FPSが設定した `stopFPS` を下回ったら終了判定
            if (_stopMilliseconds <= _stopwatch.Elapsed.TotalMilliseconds)
            {
                var average = 0.0;
                foreach (var time in _elapsedTimeCache)
                {
                    average += time;
                }
                average /= _elapsedTimeCache.Length;

                // 直近の平均FPSが下回ったら終了
                if (_stopMilliseconds <= average)
                {
                    Debug.Log(
                        $"[SpawnBenchmark] {_spawners[_currentSpawnerIndex].PrefabName} iterations:{_currentIterations} 終了: {_spawnedCount} 個配置");
                    _results[_currentSpawnerIndex].DataList.Add(_spawnedCount);
                    currentSpawner.Cleanup();
                    NextTest();
                    return;
                }
            }
            else
            {
                // 一定間隔ごとにオブジェクトを配置
                var nextSpawnCount = (int)Mathf.Floor(Time.deltaTime * _spawnPerSeconds);
                if (nextSpawnCount > 0)
                {
                    var boost = Mathf.Max(1, (int)(0.5 / Time.deltaTime / _stopFPS));
                    nextSpawnCount *= boost;
                    for (int i = 0, n = nextSpawnCount; i < n;)
                    {
                        if (n - i < 10)
                        {
                            for (; i < n; i++)
                            {
                                currentSpawner.Spawn();
                                _spawnedCount++;
                            }

                            break;
                        }

                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                        currentSpawner.Spawn();
                        _spawnedCount++;
                        i++;
                    }
                    // _lastSpawnTime = Time.time;
                }
            }

            if (_realTimeLog && Time.time - _lastLogUpdateTime >= 1f)
            {
                if (_logTextExists)
                {
                    _logText.text = $"iterations:{_currentIterations} 配置数: {_spawnedCount}";
                }

                _lastLogUpdateTime = Time.time;
            }

            // オブジェクト生成の時間はテストから除外
            _stopwatch.Restart();
        }

        public override void Interact()
        {
            if (_isBenchmarkRunning || !Utilities.IsValid(_spawners) || _spawners.Length == 0)
            {
                return;
            }

            _isBenchmarkRunning = true;
            _currentIterations = 0;
            _currentSpawnerIndex = 0;

            _results.Clear();
            _results.Add(new DataList());
            NextTest();
        }

        private void NextTest()
        {
            DisplayResults();
            
            if (_currentIterations == _testIterations)
            {
                // 次のSpawner
                _currentIterations = 0;
                _currentSpawnerIndex++;

                if (_currentSpawnerIndex >= _spawners.Length)
                {
                    // 全テスト完了
                    _isBenchmarkRunning = false;
                    return;
                }

                _results.Add(new DataList());
            }

            _currentIterations++;
            _spawnedCount = 0;
            Array.Clear(_elapsedTimeCache, 0, _elapsedTimeCache.Length);

            if (_testNameTextExists)
            {
                _testNameText.text = _spawners[_currentSpawnerIndex].PrefabName;
            }

            if (_logTextExists)
            {
                _logText.text = $"iterations:{_currentIterations}";
            }
            
            Debug.Log(
                $"[SpawnBenchmark] {_spawners[_currentSpawnerIndex].PrefabName} iterations:{_currentIterations} ベンチマーク開始");
            _stopwatch.Restart();
        }

        private void DisplayResults()
        {
            var resultText = "SpawnBenchmarkテスト\n";
            for (int i = 0, n = _results.Count; i < n; i++)
            {
                var result = _results[i].DataList;
                if (result.Count == 0)
                {
                    continue;
                }

                result.Sort();
                var max = result[result.Count - 1].Int;

                resultText += $"{_spawners[i].PrefabName}: {max}\n";
            }

            if (_resultTextExists)
            {
                _resultText.text = resultText;
            }
        }
    }
}