
using UnityEngine;
using VRC.SDK3.Components;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public class ObjectPoolBenchmark : BenchmarkRunnerBase
    {
        [SerializeField] private VRCObjectPool _vrcObjectPool;
        [SerializeField] private ObjectPool _objectPool;

        #region SpawnTest
        
        public void VRCObjectPoolSpawnTest()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                _stopwatch.Start();
                var go1 =_vrcObjectPool.TryToSpawn();
                var go2 =_vrcObjectPool.TryToSpawn();
                var go3 =_vrcObjectPool.TryToSpawn();
                var go4 =_vrcObjectPool.TryToSpawn();
                var go5 =_vrcObjectPool.TryToSpawn();
                var go6 =_vrcObjectPool.TryToSpawn();
                var go7 =_vrcObjectPool.TryToSpawn();
                var go8 =_vrcObjectPool.TryToSpawn();
                var go9 =_vrcObjectPool.TryToSpawn();
                var go10 =_vrcObjectPool.TryToSpawn();
                var go11 =_vrcObjectPool.TryToSpawn();
                var go12 =_vrcObjectPool.TryToSpawn();
                var go13 =_vrcObjectPool.TryToSpawn();
                var go14 =_vrcObjectPool.TryToSpawn();
                var go15 =_vrcObjectPool.TryToSpawn();
                var go16 =_vrcObjectPool.TryToSpawn();
                var go17 =_vrcObjectPool.TryToSpawn();
                var go18 =_vrcObjectPool.TryToSpawn();
                var go19 =_vrcObjectPool.TryToSpawn();
                var go20 =_vrcObjectPool.TryToSpawn();
                var go21 =_vrcObjectPool.TryToSpawn();
                var go22 =_vrcObjectPool.TryToSpawn();
                var go23 =_vrcObjectPool.TryToSpawn();
                var go24 =_vrcObjectPool.TryToSpawn();
                var go25 =_vrcObjectPool.TryToSpawn();
                var go26 =_vrcObjectPool.TryToSpawn();
                var go27 =_vrcObjectPool.TryToSpawn();
                var go28 =_vrcObjectPool.TryToSpawn();
                var go29 =_vrcObjectPool.TryToSpawn();
                var go30 =_vrcObjectPool.TryToSpawn();
                _stopwatch.Stop();

                _vrcObjectPool.Return(go1);
                _vrcObjectPool.Return(go2);
                _vrcObjectPool.Return(go3);
                _vrcObjectPool.Return(go4);
                _vrcObjectPool.Return(go5);
                _vrcObjectPool.Return(go6);
                _vrcObjectPool.Return(go7);
                _vrcObjectPool.Return(go8);
                _vrcObjectPool.Return(go9);
                _vrcObjectPool.Return(go10);
                _vrcObjectPool.Return(go11);
                _vrcObjectPool.Return(go12);
                _vrcObjectPool.Return(go13);
                _vrcObjectPool.Return(go14);
                _vrcObjectPool.Return(go15);
                _vrcObjectPool.Return(go16);
                _vrcObjectPool.Return(go17);
                _vrcObjectPool.Return(go18);
                _vrcObjectPool.Return(go19);
                _vrcObjectPool.Return(go20);
                _vrcObjectPool.Return(go21);
                _vrcObjectPool.Return(go22);
                _vrcObjectPool.Return(go23);
                _vrcObjectPool.Return(go24);
                _vrcObjectPool.Return(go25);
                _vrcObjectPool.Return(go26);
                _vrcObjectPool.Return(go27);
                _vrcObjectPool.Return(go28);
                _vrcObjectPool.Return(go29);
                _vrcObjectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolSpawnTest()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                _stopwatch.Start();
                var go1 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go2 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go3 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go4 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go5 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go6 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go7 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go8 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go9 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go10 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go11 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go12 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go13 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go14 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go15 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go16 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go17 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go18 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go19 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go20 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go21 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go22 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go23 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go24 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go25 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go26 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go27 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go28 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go29 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go30 =_objectPool.TryToSpawnBasedVRCObjectPool();
                _stopwatch.Stop();

                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolSpawn2Test()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                _stopwatch.Start();
                var go1 =_objectPool.TryToSpawnCheckUseArray();
                var go2 =_objectPool.TryToSpawnCheckUseArray();
                var go3 =_objectPool.TryToSpawnCheckUseArray();
                var go4 =_objectPool.TryToSpawnCheckUseArray();
                var go5 =_objectPool.TryToSpawnCheckUseArray();
                var go6 =_objectPool.TryToSpawnCheckUseArray();
                var go7 =_objectPool.TryToSpawnCheckUseArray();
                var go8 =_objectPool.TryToSpawnCheckUseArray();
                var go9 =_objectPool.TryToSpawnCheckUseArray();
                var go10 =_objectPool.TryToSpawnCheckUseArray();
                var go11 =_objectPool.TryToSpawnCheckUseArray();
                var go12 =_objectPool.TryToSpawnCheckUseArray();
                var go13 =_objectPool.TryToSpawnCheckUseArray();
                var go14 =_objectPool.TryToSpawnCheckUseArray();
                var go15 =_objectPool.TryToSpawnCheckUseArray();
                var go16 =_objectPool.TryToSpawnCheckUseArray();
                var go17 =_objectPool.TryToSpawnCheckUseArray();
                var go18 =_objectPool.TryToSpawnCheckUseArray();
                var go19 =_objectPool.TryToSpawnCheckUseArray();
                var go20 =_objectPool.TryToSpawnCheckUseArray();
                var go21 =_objectPool.TryToSpawnCheckUseArray();
                var go22 =_objectPool.TryToSpawnCheckUseArray();
                var go23 =_objectPool.TryToSpawnCheckUseArray();
                var go24 =_objectPool.TryToSpawnCheckUseArray();
                var go25 =_objectPool.TryToSpawnCheckUseArray();
                var go26 =_objectPool.TryToSpawnCheckUseArray();
                var go27 =_objectPool.TryToSpawnCheckUseArray();
                var go28 =_objectPool.TryToSpawnCheckUseArray();
                var go29 =_objectPool.TryToSpawnCheckUseArray();
                var go30 =_objectPool.TryToSpawnCheckUseArray();
                _stopwatch.Stop();

                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolSpawn3Test()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                _stopwatch.Start();
                var go1 =_objectPool.TryToSpawnUseArrayIndexof();
                var go2 =_objectPool.TryToSpawnUseArrayIndexof();
                var go3 =_objectPool.TryToSpawnUseArrayIndexof();
                var go4 =_objectPool.TryToSpawnUseArrayIndexof();
                var go5 =_objectPool.TryToSpawnUseArrayIndexof();
                var go6 =_objectPool.TryToSpawnUseArrayIndexof();
                var go7 =_objectPool.TryToSpawnUseArrayIndexof();
                var go8 =_objectPool.TryToSpawnUseArrayIndexof();
                var go9 =_objectPool.TryToSpawnUseArrayIndexof();
                var go10 =_objectPool.TryToSpawnUseArrayIndexof();
                var go11 =_objectPool.TryToSpawnUseArrayIndexof();
                var go12 =_objectPool.TryToSpawnUseArrayIndexof();
                var go13 =_objectPool.TryToSpawnUseArrayIndexof();
                var go14 =_objectPool.TryToSpawnUseArrayIndexof();
                var go15 =_objectPool.TryToSpawnUseArrayIndexof();
                var go16 =_objectPool.TryToSpawnUseArrayIndexof();
                var go17 =_objectPool.TryToSpawnUseArrayIndexof();
                var go18 =_objectPool.TryToSpawnUseArrayIndexof();
                var go19 =_objectPool.TryToSpawnUseArrayIndexof();
                var go20 =_objectPool.TryToSpawnUseArrayIndexof();
                var go21 =_objectPool.TryToSpawnUseArrayIndexof();
                var go22 =_objectPool.TryToSpawnUseArrayIndexof();
                var go23 =_objectPool.TryToSpawnUseArrayIndexof();
                var go24 =_objectPool.TryToSpawnUseArrayIndexof();
                var go25 =_objectPool.TryToSpawnUseArrayIndexof();
                var go26 =_objectPool.TryToSpawnUseArrayIndexof();
                var go27 =_objectPool.TryToSpawnUseArrayIndexof();
                var go28 =_objectPool.TryToSpawnUseArrayIndexof();
                var go29 =_objectPool.TryToSpawnUseArrayIndexof();
                var go30 =_objectPool.TryToSpawnUseArrayIndexof();
                _stopwatch.Stop();

                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        #endregion

        #region ReleaseTest
        
        public void VRCObjectPoolReleaseTest()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_vrcObjectPool.TryToSpawn();
                var go2 =_vrcObjectPool.TryToSpawn();
                var go3 =_vrcObjectPool.TryToSpawn();
                var go4 =_vrcObjectPool.TryToSpawn();
                var go5 =_vrcObjectPool.TryToSpawn();
                var go6 =_vrcObjectPool.TryToSpawn();
                var go7 =_vrcObjectPool.TryToSpawn();
                var go8 =_vrcObjectPool.TryToSpawn();
                var go9 =_vrcObjectPool.TryToSpawn();
                var go10 =_vrcObjectPool.TryToSpawn();
                var go11 =_vrcObjectPool.TryToSpawn();
                var go12 =_vrcObjectPool.TryToSpawn();
                var go13 =_vrcObjectPool.TryToSpawn();
                var go14 =_vrcObjectPool.TryToSpawn();
                var go15 =_vrcObjectPool.TryToSpawn();
                var go16 =_vrcObjectPool.TryToSpawn();
                var go17 =_vrcObjectPool.TryToSpawn();
                var go18 =_vrcObjectPool.TryToSpawn();
                var go19 =_vrcObjectPool.TryToSpawn();
                var go20 =_vrcObjectPool.TryToSpawn();
                var go21 =_vrcObjectPool.TryToSpawn();
                var go22 =_vrcObjectPool.TryToSpawn();
                var go23 =_vrcObjectPool.TryToSpawn();
                var go24 =_vrcObjectPool.TryToSpawn();
                var go25 =_vrcObjectPool.TryToSpawn();
                var go26 =_vrcObjectPool.TryToSpawn();
                var go27 =_vrcObjectPool.TryToSpawn();
                var go28 =_vrcObjectPool.TryToSpawn();
                var go29 =_vrcObjectPool.TryToSpawn();
                var go30 =_vrcObjectPool.TryToSpawn();
                
                _stopwatch.Start();
                _vrcObjectPool.Return(go1);
                _vrcObjectPool.Return(go2);
                _vrcObjectPool.Return(go3);
                _vrcObjectPool.Return(go4);
                _vrcObjectPool.Return(go5);
                _vrcObjectPool.Return(go6);
                _vrcObjectPool.Return(go7);
                _vrcObjectPool.Return(go8);
                _vrcObjectPool.Return(go9);
                _vrcObjectPool.Return(go10);
                _vrcObjectPool.Return(go11);
                _vrcObjectPool.Return(go12);
                _vrcObjectPool.Return(go13);
                _vrcObjectPool.Return(go14);
                _vrcObjectPool.Return(go15);
                _vrcObjectPool.Return(go16);
                _vrcObjectPool.Return(go17);
                _vrcObjectPool.Return(go18);
                _vrcObjectPool.Return(go19);
                _vrcObjectPool.Return(go20);
                _vrcObjectPool.Return(go21);
                _vrcObjectPool.Return(go22);
                _vrcObjectPool.Return(go23);
                _vrcObjectPool.Return(go24);
                _vrcObjectPool.Return(go25);
                _vrcObjectPool.Return(go26);
                _vrcObjectPool.Return(go27);
                _vrcObjectPool.Return(go28);
                _vrcObjectPool.Return(go29);
                _vrcObjectPool.Return(go30);
                _stopwatch.Stop();
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolReleaseTest()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go2 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go3 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go4 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go5 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go6 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go7 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go8 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go9 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go10 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go11 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go12 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go13 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go14 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go15 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go16 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go17 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go18 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go19 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go20 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go21 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go22 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go23 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go24 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go25 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go26 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go27 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go28 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go29 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go30 =_objectPool.TryToSpawnBasedVRCObjectPool();
                
                _stopwatch.Start();
                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
                _stopwatch.Stop();
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolReleaseTest2()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go2 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go3 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go4 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go5 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go6 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go7 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go8 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go9 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go10 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go11 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go12 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go13 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go14 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go15 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go16 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go17 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go18 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go19 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go20 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go21 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go22 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go23 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go24 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go25 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go26 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go27 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go28 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go29 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go30 =_objectPool.TryToSpawnBasedVRCObjectPool();
                
                _stopwatch.Start();
                _objectPool.Return2(go1);
                _objectPool.Return2(go2);
                _objectPool.Return2(go3);
                _objectPool.Return2(go4);
                _objectPool.Return2(go5);
                _objectPool.Return2(go6);
                _objectPool.Return2(go7);
                _objectPool.Return2(go8);
                _objectPool.Return2(go9);
                _objectPool.Return2(go10);
                _objectPool.Return2(go11);
                _objectPool.Return2(go12);
                _objectPool.Return2(go13);
                _objectPool.Return2(go14);
                _objectPool.Return2(go15);
                _objectPool.Return2(go16);
                _objectPool.Return2(go17);
                _objectPool.Return2(go18);
                _objectPool.Return2(go19);
                _objectPool.Return2(go20);
                _objectPool.Return2(go21);
                _objectPool.Return2(go22);
                _objectPool.Return2(go23);
                _objectPool.Return2(go24);
                _objectPool.Return2(go25);
                _objectPool.Return2(go26);
                _objectPool.Return2(go27);
                _objectPool.Return2(go28);
                _objectPool.Return2(go29);
                _objectPool.Return2(go30);
                _stopwatch.Stop();
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolReleaseTest3()
        {
            _stopwatch.Restart();
            _stopwatch.Stop();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go2 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go3 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go4 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go5 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go6 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go7 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go8 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go9 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go10 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go11 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go12 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go13 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go14 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go15 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go16 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go17 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go18 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go19 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go20 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go21 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go22 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go23 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go24 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go25 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go26 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go27 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go28 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go29 =_objectPool.TryToSpawnBasedVRCObjectPool();
                var go30 =_objectPool.TryToSpawnBasedVRCObjectPool();
                
                _stopwatch.Start();
                _objectPool.Return3(go1.GetInstanceID());
                _objectPool.Return3(go2.GetInstanceID());
                _objectPool.Return3(go3.GetInstanceID());
                _objectPool.Return3(go4.GetInstanceID());
                _objectPool.Return3(go5.GetInstanceID());
                _objectPool.Return3(go6.GetInstanceID());
                _objectPool.Return3(go7.GetInstanceID());
                _objectPool.Return3(go8.GetInstanceID());
                _objectPool.Return3(go9.GetInstanceID());
                _objectPool.Return3(go10.GetInstanceID());
                _objectPool.Return3(go11.GetInstanceID());
                _objectPool.Return3(go12.GetInstanceID());
                _objectPool.Return3(go13.GetInstanceID());
                _objectPool.Return3(go14.GetInstanceID());
                _objectPool.Return3(go15.GetInstanceID());
                _objectPool.Return3(go16.GetInstanceID());
                _objectPool.Return3(go17.GetInstanceID());
                _objectPool.Return3(go18.GetInstanceID());
                _objectPool.Return3(go19.GetInstanceID());
                _objectPool.Return3(go20.GetInstanceID());
                _objectPool.Return3(go21.GetInstanceID());
                _objectPool.Return3(go22.GetInstanceID());
                _objectPool.Return3(go23.GetInstanceID());
                _objectPool.Return3(go24.GetInstanceID());
                _objectPool.Return3(go25.GetInstanceID());
                _objectPool.Return3(go26.GetInstanceID());
                _objectPool.Return3(go27.GetInstanceID());
                _objectPool.Return3(go28.GetInstanceID());
                _objectPool.Return3(go29.GetInstanceID());
                _objectPool.Return3(go30.GetInstanceID());
                _stopwatch.Stop();
            }
            _stopwatch.Stop();
        }
        
        #endregion

        #region TotalTest
        public void VRCObjectPoolTest()
        {
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_vrcObjectPool.TryToSpawn();
                var go2 =_vrcObjectPool.TryToSpawn();
                var go3 =_vrcObjectPool.TryToSpawn();
                var go4 =_vrcObjectPool.TryToSpawn();
                var go5 =_vrcObjectPool.TryToSpawn();
                var go6 =_vrcObjectPool.TryToSpawn();
                var go7 =_vrcObjectPool.TryToSpawn();
                var go8 =_vrcObjectPool.TryToSpawn();
                var go9 =_vrcObjectPool.TryToSpawn();
                var go10 =_vrcObjectPool.TryToSpawn();
                var go11 =_vrcObjectPool.TryToSpawn();
                var go12 =_vrcObjectPool.TryToSpawn();
                var go13 =_vrcObjectPool.TryToSpawn();
                var go14 =_vrcObjectPool.TryToSpawn();
                var go15 =_vrcObjectPool.TryToSpawn();
                var go16 =_vrcObjectPool.TryToSpawn();
                var go17 =_vrcObjectPool.TryToSpawn();
                var go18 =_vrcObjectPool.TryToSpawn();
                var go19 =_vrcObjectPool.TryToSpawn();
                var go20 =_vrcObjectPool.TryToSpawn();
                var go21 =_vrcObjectPool.TryToSpawn();
                var go22 =_vrcObjectPool.TryToSpawn();
                var go23 =_vrcObjectPool.TryToSpawn();
                var go24 =_vrcObjectPool.TryToSpawn();
                var go25 =_vrcObjectPool.TryToSpawn();
                var go26 =_vrcObjectPool.TryToSpawn();
                var go27 =_vrcObjectPool.TryToSpawn();
                var go28 =_vrcObjectPool.TryToSpawn();
                var go29 =_vrcObjectPool.TryToSpawn();
                var go30 =_vrcObjectPool.TryToSpawn();

                _vrcObjectPool.Return(go1);
                _vrcObjectPool.Return(go2);
                _vrcObjectPool.Return(go3);
                _vrcObjectPool.Return(go4);
                _vrcObjectPool.Return(go5);
                _vrcObjectPool.Return(go6);
                _vrcObjectPool.Return(go7);
                _vrcObjectPool.Return(go8);
                _vrcObjectPool.Return(go9);
                _vrcObjectPool.Return(go10);
                _vrcObjectPool.Return(go11);
                _vrcObjectPool.Return(go12);
                _vrcObjectPool.Return(go13);
                _vrcObjectPool.Return(go14);
                _vrcObjectPool.Return(go15);
                _vrcObjectPool.Return(go16);
                _vrcObjectPool.Return(go17);
                _vrcObjectPool.Return(go18);
                _vrcObjectPool.Return(go19);
                _vrcObjectPool.Return(go20);
                _vrcObjectPool.Return(go21);
                _vrcObjectPool.Return(go22);
                _vrcObjectPool.Return(go23);
                _vrcObjectPool.Return(go24);
                _vrcObjectPool.Return(go25);
                _vrcObjectPool.Return(go26);
                _vrcObjectPool.Return(go27);
                _vrcObjectPool.Return(go28);
                _vrcObjectPool.Return(go29);
                _vrcObjectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolCheckUseArray()
        {
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_objectPool.TryToSpawnCheckUseArray();
                var go2 =_objectPool.TryToSpawnCheckUseArray();
                var go3 =_objectPool.TryToSpawnCheckUseArray();
                var go4 =_objectPool.TryToSpawnCheckUseArray();
                var go5 =_objectPool.TryToSpawnCheckUseArray();
                var go6 =_objectPool.TryToSpawnCheckUseArray();
                var go7 =_objectPool.TryToSpawnCheckUseArray();
                var go8 =_objectPool.TryToSpawnCheckUseArray();
                var go9 =_objectPool.TryToSpawnCheckUseArray();
                var go10 =_objectPool.TryToSpawnCheckUseArray();
                var go11 =_objectPool.TryToSpawnCheckUseArray();
                var go12 =_objectPool.TryToSpawnCheckUseArray();
                var go13 =_objectPool.TryToSpawnCheckUseArray();
                var go14 =_objectPool.TryToSpawnCheckUseArray();
                var go15 =_objectPool.TryToSpawnCheckUseArray();
                var go16 =_objectPool.TryToSpawnCheckUseArray();
                var go17 =_objectPool.TryToSpawnCheckUseArray();
                var go18 =_objectPool.TryToSpawnCheckUseArray();
                var go19 =_objectPool.TryToSpawnCheckUseArray();
                var go20 =_objectPool.TryToSpawnCheckUseArray();
                var go21 =_objectPool.TryToSpawnCheckUseArray();
                var go22 =_objectPool.TryToSpawnCheckUseArray();
                var go23 =_objectPool.TryToSpawnCheckUseArray();
                var go24 =_objectPool.TryToSpawnCheckUseArray();
                var go25 =_objectPool.TryToSpawnCheckUseArray();
                var go26 =_objectPool.TryToSpawnCheckUseArray();
                var go27 =_objectPool.TryToSpawnCheckUseArray();
                var go28 =_objectPool.TryToSpawnCheckUseArray();
                var go29 =_objectPool.TryToSpawnCheckUseArray();
                var go30 =_objectPool.TryToSpawnCheckUseArray();

                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolTestUseArrayIndexof()
        {
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                var go1 =_objectPool.TryToSpawnUseArrayIndexof();
                var go2 =_objectPool.TryToSpawnUseArrayIndexof();
                var go3 =_objectPool.TryToSpawnUseArrayIndexof();
                var go4 =_objectPool.TryToSpawnUseArrayIndexof();
                var go5 =_objectPool.TryToSpawnUseArrayIndexof();
                var go6 =_objectPool.TryToSpawnUseArrayIndexof();
                var go7 =_objectPool.TryToSpawnUseArrayIndexof();
                var go8 =_objectPool.TryToSpawnUseArrayIndexof();
                var go9 =_objectPool.TryToSpawnUseArrayIndexof();
                var go10 =_objectPool.TryToSpawnUseArrayIndexof();
                var go11 =_objectPool.TryToSpawnUseArrayIndexof();
                var go12 =_objectPool.TryToSpawnUseArrayIndexof();
                var go13 =_objectPool.TryToSpawnUseArrayIndexof();
                var go14 =_objectPool.TryToSpawnUseArrayIndexof();
                var go15 =_objectPool.TryToSpawnUseArrayIndexof();
                var go16 =_objectPool.TryToSpawnUseArrayIndexof();
                var go17 =_objectPool.TryToSpawnUseArrayIndexof();
                var go18 =_objectPool.TryToSpawnUseArrayIndexof();
                var go19 =_objectPool.TryToSpawnUseArrayIndexof();
                var go20 =_objectPool.TryToSpawnUseArrayIndexof();
                var go21 =_objectPool.TryToSpawnUseArrayIndexof();
                var go22 =_objectPool.TryToSpawnUseArrayIndexof();
                var go23 =_objectPool.TryToSpawnUseArrayIndexof();
                var go24 =_objectPool.TryToSpawnUseArrayIndexof();
                var go25 =_objectPool.TryToSpawnUseArrayIndexof();
                var go26 =_objectPool.TryToSpawnUseArrayIndexof();
                var go27 =_objectPool.TryToSpawnUseArrayIndexof();
                var go28 =_objectPool.TryToSpawnUseArrayIndexof();
                var go29 =_objectPool.TryToSpawnUseArrayIndexof();
                var go30 =_objectPool.TryToSpawnUseArrayIndexof();

                _objectPool.Return(go1);
                _objectPool.Return(go2);
                _objectPool.Return(go3);
                _objectPool.Return(go4);
                _objectPool.Return(go5);
                _objectPool.Return(go6);
                _objectPool.Return(go7);
                _objectPool.Return(go8);
                _objectPool.Return(go9);
                _objectPool.Return(go10);
                _objectPool.Return(go11);
                _objectPool.Return(go12);
                _objectPool.Return(go13);
                _objectPool.Return(go14);
                _objectPool.Return(go15);
                _objectPool.Return(go16);
                _objectPool.Return(go17);
                _objectPool.Return(go18);
                _objectPool.Return(go19);
                _objectPool.Return(go20);
                _objectPool.Return(go21);
                _objectPool.Return(go22);
                _objectPool.Return(go23);
                _objectPool.Return(go24);
                _objectPool.Return(go25);
                _objectPool.Return(go26);
                _objectPool.Return(go27);
                _objectPool.Return(go28);
                _objectPool.Return(go29);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        #endregion
        
        public void VRCObjectPoolLaterTest()
        {
            var go1 =_vrcObjectPool.TryToSpawn();
            var go2 =_vrcObjectPool.TryToSpawn();
            var go3 =_vrcObjectPool.TryToSpawn();
            var go4 =_vrcObjectPool.TryToSpawn();
            var go5 =_vrcObjectPool.TryToSpawn();
            var go6 =_vrcObjectPool.TryToSpawn();
            var go7 =_vrcObjectPool.TryToSpawn();
            var go8 =_vrcObjectPool.TryToSpawn();
            var go9 =_vrcObjectPool.TryToSpawn();
            var go10 =_vrcObjectPool.TryToSpawn();
            var go11 =_vrcObjectPool.TryToSpawn();
            var go12 =_vrcObjectPool.TryToSpawn();
            var go13 =_vrcObjectPool.TryToSpawn();
            var go14 =_vrcObjectPool.TryToSpawn();
            var go15 =_vrcObjectPool.TryToSpawn();
            var go16 =_vrcObjectPool.TryToSpawn();
            var go17 =_vrcObjectPool.TryToSpawn();
            var go18 =_vrcObjectPool.TryToSpawn();
            var go19 =_vrcObjectPool.TryToSpawn();
            var go20 =_vrcObjectPool.TryToSpawn();
            var go21 =_vrcObjectPool.TryToSpawn();
            var go22 =_vrcObjectPool.TryToSpawn();
            var go23 =_vrcObjectPool.TryToSpawn();
            var go24 =_vrcObjectPool.TryToSpawn();
            var go25 =_vrcObjectPool.TryToSpawn();
            var go26 =_vrcObjectPool.TryToSpawn();
            var go27 =_vrcObjectPool.TryToSpawn();
            var go28 =_vrcObjectPool.TryToSpawn();
            var go29 =_vrcObjectPool.TryToSpawn();
            var go30 =_vrcObjectPool.TryToSpawn();
            _vrcObjectPool.Return(go30);
            
            
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                go30 =_vrcObjectPool.TryToSpawn();
                _vrcObjectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolLaterTest()
        {
            var go1 =_objectPool.TryToSpawnCheckUseArray();
            var go2 =_objectPool.TryToSpawnCheckUseArray();
            var go3 =_objectPool.TryToSpawnCheckUseArray();
            var go4 =_objectPool.TryToSpawnCheckUseArray();
            var go5 =_objectPool.TryToSpawnCheckUseArray();
            var go6 =_objectPool.TryToSpawnCheckUseArray();
            var go7 =_objectPool.TryToSpawnCheckUseArray();
            var go8 =_objectPool.TryToSpawnCheckUseArray();
            var go9 =_objectPool.TryToSpawnCheckUseArray();
            var go10 =_objectPool.TryToSpawnCheckUseArray();
            var go11 =_objectPool.TryToSpawnCheckUseArray();
            var go12 =_objectPool.TryToSpawnCheckUseArray();
            var go13 =_objectPool.TryToSpawnCheckUseArray();
            var go14 =_objectPool.TryToSpawnCheckUseArray();
            var go15 =_objectPool.TryToSpawnCheckUseArray();
            var go16 =_objectPool.TryToSpawnCheckUseArray();
            var go17 =_objectPool.TryToSpawnCheckUseArray();
            var go18 =_objectPool.TryToSpawnCheckUseArray();
            var go19 =_objectPool.TryToSpawnCheckUseArray();
            var go20 =_objectPool.TryToSpawnCheckUseArray();
            var go21 =_objectPool.TryToSpawnCheckUseArray();
            var go22 =_objectPool.TryToSpawnCheckUseArray();
            var go23 =_objectPool.TryToSpawnCheckUseArray();
            var go24 =_objectPool.TryToSpawnCheckUseArray();
            var go25 =_objectPool.TryToSpawnCheckUseArray();
            var go26 =_objectPool.TryToSpawnCheckUseArray();
            var go27 =_objectPool.TryToSpawnCheckUseArray();
            var go28 =_objectPool.TryToSpawnCheckUseArray();
            var go29 =_objectPool.TryToSpawnCheckUseArray();
            var go30 =_objectPool.TryToSpawnCheckUseArray();
            _objectPool.Return(go30);
            
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                go30 =_objectPool.TryToSpawnCheckUseArray();
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolLaterArrayIndexofTest()
        {
            var go1 =_objectPool.TryToSpawnCheckUseArray();
            var go2 =_objectPool.TryToSpawnCheckUseArray();
            var go3 =_objectPool.TryToSpawnCheckUseArray();
            var go4 =_objectPool.TryToSpawnCheckUseArray();
            var go5 =_objectPool.TryToSpawnCheckUseArray();
            var go6 =_objectPool.TryToSpawnCheckUseArray();
            var go7 =_objectPool.TryToSpawnCheckUseArray();
            var go8 =_objectPool.TryToSpawnCheckUseArray();
            var go9 =_objectPool.TryToSpawnCheckUseArray();
            var go10 =_objectPool.TryToSpawnCheckUseArray();
            var go11 =_objectPool.TryToSpawnCheckUseArray();
            var go12 =_objectPool.TryToSpawnCheckUseArray();
            var go13 =_objectPool.TryToSpawnCheckUseArray();
            var go14 =_objectPool.TryToSpawnCheckUseArray();
            var go15 =_objectPool.TryToSpawnCheckUseArray();
            var go16 =_objectPool.TryToSpawnCheckUseArray();
            var go17 =_objectPool.TryToSpawnCheckUseArray();
            var go18 =_objectPool.TryToSpawnCheckUseArray();
            var go19 =_objectPool.TryToSpawnCheckUseArray();
            var go20 =_objectPool.TryToSpawnCheckUseArray();
            var go21 =_objectPool.TryToSpawnCheckUseArray();
            var go22 =_objectPool.TryToSpawnCheckUseArray();
            var go23 =_objectPool.TryToSpawnCheckUseArray();
            var go24 =_objectPool.TryToSpawnCheckUseArray();
            var go25 =_objectPool.TryToSpawnCheckUseArray();
            var go26 =_objectPool.TryToSpawnCheckUseArray();
            var go27 =_objectPool.TryToSpawnCheckUseArray();
            var go28 =_objectPool.TryToSpawnCheckUseArray();
            var go29 =_objectPool.TryToSpawnCheckUseArray();
            var go30 =_objectPool.TryToSpawnCheckUseArray();
            _objectPool.Return(go30);
            
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                go30 =_objectPool.TryToSpawnUseArrayIndexof();
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolLaterTest2()
        {
            var go1 =_objectPool.TryToSpawnCheckUseArray();
            var go2 =_objectPool.TryToSpawnCheckUseArray();
            var go3 =_objectPool.TryToSpawnCheckUseArray();
            var go4 =_objectPool.TryToSpawnCheckUseArray();
            var go5 =_objectPool.TryToSpawnCheckUseArray();
            var go6 =_objectPool.TryToSpawnCheckUseArray();
            var go7 =_objectPool.TryToSpawnCheckUseArray();
            var go8 =_objectPool.TryToSpawnCheckUseArray();
            var go9 =_objectPool.TryToSpawnCheckUseArray();
            var go10 =_objectPool.TryToSpawnCheckUseArray();
            var go11 =_objectPool.TryToSpawnCheckUseArray();
            var go12 =_objectPool.TryToSpawnCheckUseArray();
            var go13 =_objectPool.TryToSpawnCheckUseArray();
            var go14 =_objectPool.TryToSpawnCheckUseArray();
            var go15 =_objectPool.TryToSpawnCheckUseArray();
            var go16 =_objectPool.TryToSpawnCheckUseArray();
            var go17 =_objectPool.TryToSpawnCheckUseArray();
            var go18 =_objectPool.TryToSpawnCheckUseArray();
            var go19 =_objectPool.TryToSpawnCheckUseArray();
            var go20 =_objectPool.TryToSpawnCheckUseArray();
            var go21 =_objectPool.TryToSpawnCheckUseArray();
            var go22 =_objectPool.TryToSpawnCheckUseArray();
            var go23 =_objectPool.TryToSpawnCheckUseArray();
            var go24 =_objectPool.TryToSpawnCheckUseArray();
            var go25 =_objectPool.TryToSpawnCheckUseArray();
            var go26 =_objectPool.TryToSpawnCheckUseArray();
            var go27 =_objectPool.TryToSpawnCheckUseArray();
            var go28 =_objectPool.TryToSpawnCheckUseArray();
            var go29 =_objectPool.TryToSpawnCheckUseArray();
            var go30 =_objectPool.TryToSpawnCheckUseArray();
            
            _objectPool.Return(go3);
            _objectPool.Return(go6);
            _objectPool.Return(go9);
            _objectPool.Return(go12);
            _objectPool.Return(go15);
            _objectPool.Return(go18);
            _objectPool.Return(go21);
            _objectPool.Return(go24);
            _objectPool.Return(go27);
            _objectPool.Return(go30);
            
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                go3 =_objectPool.TryToSpawnCheckUseArray();
                go6 =_objectPool.TryToSpawnCheckUseArray();
                go9 =_objectPool.TryToSpawnCheckUseArray();
                go12 =_objectPool.TryToSpawnCheckUseArray();
                go15 =_objectPool.TryToSpawnCheckUseArray();
                go18 =_objectPool.TryToSpawnCheckUseArray();
                go21 =_objectPool.TryToSpawnCheckUseArray();
                go24 =_objectPool.TryToSpawnCheckUseArray();
                go27 =_objectPool.TryToSpawnCheckUseArray();
                go30 =_objectPool.TryToSpawnCheckUseArray();
                _objectPool.Return(go3);
                _objectPool.Return(go6);
                _objectPool.Return(go9);
                _objectPool.Return(go12);
                _objectPool.Return(go15);
                _objectPool.Return(go18);
                _objectPool.Return(go21);
                _objectPool.Return(go24);
                _objectPool.Return(go27);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        public void ObjectPoolLaterArrayIndexofTest2()
        {
            var go1 =_objectPool.TryToSpawnCheckUseArray();
            var go2 =_objectPool.TryToSpawnCheckUseArray();
            var go3 =_objectPool.TryToSpawnCheckUseArray();
            var go4 =_objectPool.TryToSpawnCheckUseArray();
            var go5 =_objectPool.TryToSpawnCheckUseArray();
            var go6 =_objectPool.TryToSpawnCheckUseArray();
            var go7 =_objectPool.TryToSpawnCheckUseArray();
            var go8 =_objectPool.TryToSpawnCheckUseArray();
            var go9 =_objectPool.TryToSpawnCheckUseArray();
            var go10 =_objectPool.TryToSpawnCheckUseArray();
            var go11 =_objectPool.TryToSpawnCheckUseArray();
            var go12 =_objectPool.TryToSpawnCheckUseArray();
            var go13 =_objectPool.TryToSpawnCheckUseArray();
            var go14 =_objectPool.TryToSpawnCheckUseArray();
            var go15 =_objectPool.TryToSpawnCheckUseArray();
            var go16 =_objectPool.TryToSpawnCheckUseArray();
            var go17 =_objectPool.TryToSpawnCheckUseArray();
            var go18 =_objectPool.TryToSpawnCheckUseArray();
            var go19 =_objectPool.TryToSpawnCheckUseArray();
            var go20 =_objectPool.TryToSpawnCheckUseArray();
            var go21 =_objectPool.TryToSpawnCheckUseArray();
            var go22 =_objectPool.TryToSpawnCheckUseArray();
            var go23 =_objectPool.TryToSpawnCheckUseArray();
            var go24 =_objectPool.TryToSpawnCheckUseArray();
            var go25 =_objectPool.TryToSpawnCheckUseArray();
            var go26 =_objectPool.TryToSpawnCheckUseArray();
            var go27 =_objectPool.TryToSpawnCheckUseArray();
            var go28 =_objectPool.TryToSpawnCheckUseArray();
            var go29 =_objectPool.TryToSpawnCheckUseArray();
            var go30 =_objectPool.TryToSpawnCheckUseArray();
            
            _objectPool.Return(go3);
            _objectPool.Return(go6);
            _objectPool.Return(go9);
            _objectPool.Return(go12);
            _objectPool.Return(go15);
            _objectPool.Return(go18);
            _objectPool.Return(go21);
            _objectPool.Return(go24);
            _objectPool.Return(go27);
            _objectPool.Return(go30);
            
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                go3 =_objectPool.TryToSpawnUseArrayIndexof();
                go6 =_objectPool.TryToSpawnUseArrayIndexof();
                go9 =_objectPool.TryToSpawnUseArrayIndexof();
                go12 =_objectPool.TryToSpawnUseArrayIndexof();
                go15 =_objectPool.TryToSpawnUseArrayIndexof();
                go18 =_objectPool.TryToSpawnUseArrayIndexof();
                go21 =_objectPool.TryToSpawnUseArrayIndexof();
                go24 =_objectPool.TryToSpawnUseArrayIndexof();
                go27 =_objectPool.TryToSpawnUseArrayIndexof();
                go30 =_objectPool.TryToSpawnUseArrayIndexof();
                _objectPool.Return(go3);
                _objectPool.Return(go6);
                _objectPool.Return(go9);
                _objectPool.Return(go12);
                _objectPool.Return(go15);
                _objectPool.Return(go18);
                _objectPool.Return(go21);
                _objectPool.Return(go24);
                _objectPool.Return(go27);
                _objectPool.Return(go30);
            }
            _stopwatch.Stop();
        }
        
        
    }
}