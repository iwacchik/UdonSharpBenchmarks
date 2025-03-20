using System;
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public class ObjectPool : UdonSharpBehaviour
    {
        public GameObject[] Pool = new GameObject[0];
        
        private DataDictionary _indices = new DataDictionary();
        private DataDictionary _indices2 = new DataDictionary();
        private bool[] _used;
        
        private int _lastSpawnIndex = -1;
        private bool _initialized;
        
        private void Start()
        {
            _used = new bool[Pool.Length];

            for (int i = 0, n = Pool.Length; i < n; i++)
            {
                Pool[i].SetActive(false);
                _indices.Add(Pool[i], i);
                _indices2.Add(Pool[i].GetInstanceID(), i);
            }
            
            _initialized = true;
        }

        public GameObject TryToSpawnBasedVRCObjectPool()
        {
            if (!_initialized)
            {
                return null;
            }
            
            for (int i = 0, n = Pool.Length; i < n; ++i)
            {
                var index = (_lastSpawnIndex + 1) % n;
                var obj = Pool[index];
                if (!obj.activeInHierarchy)
                {
                    obj.SetActive(true);
                    _lastSpawnIndex = index;
                    return obj;
                }
            }

            return null;
        }
        
        public GameObject TryToSpawnCheckUseArray()
        {
            if (!_initialized)
            {
                return null;
            }
            
            for (int i = 0, n = Pool.Length; i < n; ++i)
            {
                var index = (_lastSpawnIndex + 1) % n;

                if (!_used[index])
                {
                    var obj = Pool[index];
                    obj.SetActive(true);
                    _used[index] = true;
                    _lastSpawnIndex = index;
                    return obj;
                }
            }

            return null;
        }
        
        public GameObject TryToSpawnUseArrayIndexof()
        {
            if (!_initialized)
            {
                return null;
            }
            
            var index = Array.IndexOf(_used, false);
            if (index == -1)
            {
                return null;
            }
            
            var obj = Pool[index];
            obj.SetActive(true);
            _used[index] = true;
            return obj;
        }
        
        public void Return(GameObject obj)
        {
            if (_indices.TryGetValue(obj, out var res))
            {
                var index = res.Int;
                obj.SetActive(false);
                _used[index] = false;
            }
        }
        
        public void Return2(GameObject obj)
        {
            if (_indices2.TryGetValue(obj.GetInstanceID(), out var res))
            {
                var index = res.Int;
                obj.SetActive(false);
                _used[index] = false;
            }
        }
        
        public void Return3(int instanceID)
        {
            if (_indices2.TryGetValue(instanceID, out var res))
            {
                var index = res.Int;
                Pool[index].SetActive(false);
                _used[index] = false;
            }
        }
    }
}