
using UdonSharp;
using UnityEngine;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public abstract class ObjectSpawnerBase : UdonSharpBehaviour
    {
        public virtual string PrefabName => "";
        
        public abstract GameObject Spawn();
        public abstract void Cleanup();
    }
}
