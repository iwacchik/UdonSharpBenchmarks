using System;
using System.Text;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;

#if !COMPILER_UDONSHARP && UNITY_EDITOR // These using statements must be wrapped in this check to prevent issues on builds
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UdonSharpEditor;
using UnityEditorInternal;
#endif

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    /// <summary>
    /// Example behaviour that has a custom inspector
    /// </summary>
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class UdonSpeedBenchmark : UdonSharpBehaviour
    {
        [HideInInspector]
        public string SettingsString;
        [HideInInspector]
        public BenchmarkRunnerBase[] Runners;

        private DataDictionary _runnersIndex = new DataDictionary();

        // ベンチマーク実行情報
        private DataList _benchmarkData;
        private bool _isExecuting;
        private int _taskIndex = 0;

        [SerializeField]
        private int _maxRunCount = 10;
        private int _runCount = 0;
        private int _runFrame;
        private string _runningTask = string.Empty;
        private DataDictionary _results = new DataDictionary();
        
        // ログ表示
        [SerializeField] private TMP_Text _realtimeLog;
        [SerializeField] private TMP_InputField _resultsText;

        private void Start()
        {
            Initialize();
        }

        private void LateUpdate()
        {
            if (!string.IsNullOrEmpty(_runningTask) && Time.frameCount - _runFrame >= 2)
            {
                // ここに到達した時点でFailed
                FailTask();
            }
        }

        private void Initialize()
        {
            if (string.IsNullOrEmpty(SettingsString))
            {
                return;
            }

            // Runnersのインデックスを作成
            for (int i = 0, n = Runners.Length; i < n; i++)
            {
                if (Utilities.IsValid(Runners[i]))
                {
                    var go = Runners[i].gameObject;
                    _runnersIndex[go.name] = go;
                }
            }

            // テスト項目をパース
            VRCJson.TryDeserializeFromJson(SettingsString, out var data);
            _benchmarkData = data.DataDictionary["Settings"].DataList;
        }
        
        public void RunBenchmark()
        {
            if (_isExecuting || _benchmarkData == null)
            {
                return;
            }

            _isExecuting = true;
            _taskIndex = 0;
            _runCount = 0;
            _results.Clear();
            _NextRun();
        }

        public void CompleteTask(string methodName, int count, double resultMilliseconds, int iterations)
        {
            Debug.Log($"==== CompleteMethod {_runningTask}[{_runCount}] ====");
            SetResult(true, _runningTask, resultMilliseconds);
            _runningTask = string.Empty;

            SendCustomEventDelayedFrames(nameof(_NextRun), 5);
        }

        private void FailTask()
        {
            Debug.Log($"==== FailMethod {_runningTask}[{_runCount}] ====");
            SetResult(false, _runningTask, 0);
            _runningTask = string.Empty;

            SendCustomEventDelayedFrames(nameof(_NextRun), 5);
        }

        public void _NextRun()
        {
            if (_runCount >= _maxRunCount)
            {
                _taskIndex++;
                _runCount = 0;
            }

            if (_taskIndex >= _benchmarkData.Count)
            {
                // 終了
                _isExecuting = false;
                
                // 最終ログ出力
                OutputAllResult();
                return;
            }

            _runCount++;
            var data = _benchmarkData[_taskIndex].DataDictionary;
            var prefab = (GameObject)_runnersIndex[data["RunnerName"].String].Reference;
            var task = data["TaskName"].String;
            var iterations = (int)data["Iterations"].Double;

            var runner = Instantiate(prefab).GetComponent<BenchmarkRunnerBase>();
            runner.RunBenchmark(task, _runCount, iterations, (IUdonEventReceiver)this);
            _runFrame = Time.frameCount;
            _runningTask = $"{task}_{iterations}";
            Debug.Log($"==== Start Method {_runningTask}[{_runCount}] ====");
        }

        private void SetResult(bool isSuccess, string taskName, double resultMilliseconds)
        {
            var result = GetResult($"{taskName}");

            result["RunCount"] = result["RunCount"].Int + 1;
            result["SuccessCount"] = result["SuccessCount"].Int + (isSuccess ? 1 : 0);
            result["ElapsedTotal"] = result["ElapsedTotal"].Double + (isSuccess ? resultMilliseconds : 0);
            result["ElapsedMax"] =
                Math.Max(result["ElapsedMax"].Double, (isSuccess ? resultMilliseconds : double.MinValue));
            result["ElapsedMin"] =
                Math.Min(result["ElapsedMin"].Double, (isSuccess ? resultMilliseconds : double.MaxValue));

            if (!result.TryGetValue("ElapsedList", out var list))
            {
                list = result["ElapsedList"] = new DataList();
            }
            list.DataList.Add(resultMilliseconds);

            // リアルタイムログ出力
            if (Utilities.IsValid(_realtimeLog))
            {
                _realtimeLog.text = OutputResult(taskName, result);
            }
        }

        private DataDictionary GetResult(string methodName)
        {
            var containsKey = _results.ContainsKey(methodName);
            if (!containsKey)
            {
                var dic = new DataDictionary();
                dic["ElapsedTotal"] = 0.0;
                dic["ElapsedMax"] = double.MinValue;
                dic["ElapsedMin"] = double.MaxValue;
                dic["RunCount"] = 0;
                dic["SuccessCount"] = 0;

                _results.Add(methodName, dic);
            }

            return _results[methodName].DataDictionary;
        }

        private void OutputAllResult()
        {
            var sb = new StringBuilder();

            var keyList = _results.GetKeys();
            for (var i = 0; i < keyList.Count; i++)
            {
                var key = keyList[i];
                var result = _results[key].DataDictionary;
                
                sb.AppendLine(
                    OutputResult(key.String, result)
                    );
            }

            Debug.Log(sb.ToString());

            if (Utilities.IsValid(_resultsText))
            {
                _resultsText.text = sb.ToString();
            }

        }

        private string OutputResult( string name, DataDictionary result)
        {
            var runCount = result["RunCount"].Int;
            var successCount = result["SuccessCount"].Int;
            var countText = $"[{successCount}/{runCount}]";
            var aveText = successCount != 0 ? $"{result["ElapsedTotal"].Double / runCount:F3}ms" : "===";
            var minText = successCount != 0 ? $"{result["ElapsedMin"].Double:F3}ms" : "===";
            var maxText = successCount != 0 ? $"{result["ElapsedMax"].Double:F3}ms" : "===";
            var median = successCount != 0 ? $"{CalculateMedian(result["ElapsedList"].DataList)}ms" : "===";
            
            return $"{name} {countText} Median:{median} Min:{minText} Max:{maxText}";
        }
        
        public double CalculateMedian(DataList list)
        {
            list.Sort();
            
            int length = list.Count;
            // 奇数の場合は中央の値を返す
            if (length % 2 == 1)
            {
                return list[length / 2].Double;
            }
            // 偶数の場合は中央2つの値の平均を返す
            else
            {
                int middleIndex = length / 2;
                return (list[middleIndex - 1].Double + list[middleIndex].Double) / 2f;
            }
        }
    }


    // Editor scripts must be wrapped in a UNITY_EDITOR check to prevent issues while uploading worlds. The !COMPILER_UDONSHARP check prevents UdonSharp from throwing errors about unsupported code here.
#if !COMPILER_UDONSHARP && UNITY_EDITOR
    [CustomEditor(typeof(UdonSpeedBenchmark))]
    public class BenchmarkTesterEditor : Editor
    {
        [Serializable]
        private class Setting
        {
            public string RunnerName; // _methods から選択
            public string TaskName; // public メソッドから選択
            public int Iterations;
        }

        private List<Setting> _settings;
        private ReorderableList _reorderableList;
        private SerializedProperty _runnersProperty;

        private void OnEnable()
        {
            _runnersProperty = serializedObject.FindProperty("Runners");
            _runnersProperty.isExpanded = true;

            InitializeReorderableList();
        }

        public override void OnInspectorGUI()
        {
            // Draws the default convert to UdonBehaviour button, program asset field, sync settings, etc.
            if (UdonSharpGUI.DrawDefaultUdonSharpBehaviourHeader(target)) return;

            serializedObject.Update();
            
            DrawDefaultInspector();

            _reorderableList.DoLayoutList();

            // 標準インスペクターで _methods を表示
            EditorGUILayout.PropertyField(_runnersProperty, new GUIContent("実行オブジェクト一覧"), true);

            serializedObject.ApplyModifiedProperties();
        }

        private void InitializeReorderableList()
        {
            var inspectorBehaviour = (UdonSpeedBenchmark)target;

            // JSON から設定を復元
            if (!string.IsNullOrEmpty(inspectorBehaviour.SettingsString))
            {
                try
                {
                    _settings = JsonUtility.FromJson<ListWrapper>(inspectorBehaviour.SettingsString)?.Settings ??
                                new List<Setting>();
                }
                catch
                {
                    Debug.LogWarning("Failed to parse JSON from stringVal.");
                    _settings = new List<Setting>();
                }
            }
            else
            {
                _settings = new List<Setting>();
            }

            _reorderableList = new ReorderableList(_settings, typeof(Setting), true, true, true, true)
            {
                drawHeaderCallback = rect => { EditorGUI.LabelField(rect, "ベンチマーク項目"); },
                drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                    // データ変更を監視するブロック開始
                    EditorGUI.BeginChangeCheck();
                    
                    var element = _settings[index];
                    var runners = inspectorBehaviour.Runners;

                    rect.y += 2;

                    // RunnerNameとTaskNameをキャッシュ
                    var runnerNameCache = element.RunnerName;
                    var taskNameCache = element.TaskName;

                    // Methods ドロップダウン
                    if (runners != null && runners.Length > 0)
                    {
                        var methodNames = runners.Select(m => m != null ? m.name : "").ToArray();
                        int currentMethodIndex = Array.FindIndex(methodNames, name => name == element.RunnerName);
                        currentMethodIndex = Mathf.Max(currentMethodIndex, 0);

                        currentMethodIndex = EditorGUI.Popup(
                            new Rect(rect.x, rect.y, rect.width * 0.3f, EditorGUIUtility.singleLineHeight),
                            currentMethodIndex,
                            methodNames
                        );

                        element.RunnerName = methodNames[currentMethodIndex];

                        // Function ドロップダウン (SelectedMethodName に基づく)
                        var selectedMethod = runners[currentMethodIndex];
                        var functionNames = selectedMethod != null
                            ? GetPublicMethodNames(selectedMethod)
                            : new string[] { "" };

                        int currentFunctionIndex = Array.FindIndex(functionNames, name => name == element.TaskName);
                        currentFunctionIndex = Mathf.Max(currentFunctionIndex, 0);

                        currentFunctionIndex = EditorGUI.Popup(
                            new Rect(rect.x + rect.width * 0.35f, rect.y, rect.width * 0.3f,
                                EditorGUIUtility.singleLineHeight),
                            currentFunctionIndex,
                            functionNames
                        );

                        element.TaskName = functionNames[currentFunctionIndex];

                        // Iterations フィールド
                        element.Iterations = EditorGUI.IntField(
                            new Rect(rect.x + rect.width * 0.7f, rect.y, rect.width * 0.2f,
                                EditorGUIUtility.singleLineHeight),
                            element.Iterations
                        );
                    }
                    else
                    {
                        EditorGUI.LabelField(
                            new Rect(rect.x, rect.y, rect.width * 0.6f, EditorGUIUtility.singleLineHeight),
                            "No Runners Available");
                        element.RunnerName = "";
                        element.TaskName = "";
                    }

                    if (runnerNameCache != element.RunnerName || taskNameCache != element.TaskName)
                    {
                        OnReorderableListChanged();
                    }

                    if (EditorGUI.EndChangeCheck())
                    {
                        OnReorderableListChanged();
                    }
                },
                onAddCallback = list =>
                {
                    _settings.Add(new Setting
                    {
                        RunnerName = null,
                        TaskName = null,
                        Iterations = 1
                    });
                },
                onRemoveCallback = list =>
                {
                    if (list.index >= 0 && list.index < _settings.Count)
                    {
                        _settings.RemoveAt(list.index);
                    }
                },
                onChangedCallback = list => OnReorderableListChanged(),
            };
        }

        private void OnReorderableListChanged()
        {
            var inspectorBehaviour = (UdonSpeedBenchmark)target;

            // JSON にシリアライズして保存
            var wrapper = new ListWrapper { Settings = _settings };
            inspectorBehaviour.SettingsString = JsonUtility.ToJson(wrapper);

            Debug.Log($"OnReorderableListChanged: {inspectorBehaviour.SettingsString}");
            // inspectorBehaviour.SettingsString = ConvertToPlainJson(_settings);

            Undo.RecordObject(inspectorBehaviour, "ReorderableList Modified");
            EditorUtility.SetDirty(inspectorBehaviour);
        }

        private void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            // 再生モードに入ったとき
            if (state == PlayModeStateChange.EnteredPlayMode)
            {
                OnReorderableListChanged();
            }
        }

        private string[] GetPublicMethodNames(BenchmarkRunnerBase benchmarkRunnerBase)
        {
            return benchmarkRunnerBase
                .GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Where(m => !m.IsSpecialName) // プロパティやイベントを除外
                .Select(m => m.Name)
                .ToArray();
        }

        private string ConvertToPlainJson(List<Setting> settings)
        {
            // 1. ListWrapper で一旦シリアライズ
            string wrappedJson = JsonUtility.ToJson(new ListWrapper { Settings = settings });

            // 2. 外側の "Settings":[] 部分を取り除く
            int startIndex = wrappedJson.IndexOf('['); // リスト部分の開始位置
            int endIndex = wrappedJson.LastIndexOf(']'); // リスト部分の終了位置

            if (startIndex != -1 && endIndex != -1)
            {
                return wrappedJson.Substring(startIndex, endIndex - startIndex + 1);
            }

            // 万が一解析に失敗した場合、空のリストを返す
            return "[]";
        }

        [System.Serializable]
        private class ListWrapper
        {
            public List<Setting> Settings;
        }
    }
#endif
}