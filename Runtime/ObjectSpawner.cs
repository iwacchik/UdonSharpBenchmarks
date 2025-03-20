using System;
using System.Diagnostics;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public class ObjectSpawner : ObjectSpawnerBase
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _parent;

        [SerializeField] private float _xMin = -4f;
        [SerializeField] private float _xMax = 4f;
        [SerializeField] private float _yMin = 1f;
        [SerializeField] private float _yMax = 9f;
        [SerializeField] private float _zMin = 1f;
        [SerializeField] private float _zMax = 9f;

        private Vector3 _position = Vector3.zero;
        private Quaternion _rotation = Quaternion.identity;

        private Transform _parentInternal;

        public override string PrefabName => Utilities.IsValid(_prefab) ? _prefab.name : "";

        private void SetupParent()
        {
            var go = Instantiate(_parent.gameObject, _parent.parent);
            go.name = $"SpawnerParent_{name}";
            _parentInternal = go.transform;
        }

        public override GameObject Spawn()
        {
            if (!Utilities.IsValid(_parentInternal))
            {
                SetupParent();
            }

            _position = new Vector3(Random.Range(_xMin, _xMax), Random.Range(_yMin, _yMax), Random.Range(_zMin, _zMax));

            return Instantiate(_prefab, _position, _rotation, _parentInternal);
        }

        public override void Cleanup()
        {
            Debug.Log("[SpawnBenchmark] すべてのオブジェクトを削除します...");
            Destroy(_parentInternal.gameObject);
            _parentInternal = null;
            Debug.Log("[SpawnBenchmark] 削除完了");
        }
    }
}