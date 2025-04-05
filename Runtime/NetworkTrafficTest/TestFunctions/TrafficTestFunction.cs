
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon.Common;

namespace IwacchiLab.Benchmarks.Network
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class TrafficTestFunction : UdonSharpBehaviour
    {
        private NetworkTrafficBenchmark _onSyncListener = null;
        
        public virtual string TestName => "";
        protected virtual int Variable => 0;
        
        public override void OnPostSerialization(SerializationResult result)
        {
            if (result.success)
            {
                var byteCount = result.byteCount;
                Debug.Log( $"{gameObject.name} TestName:{TestName}_{Variable} {byteCount}byte" );
                if (Utilities.IsValid(_onSyncListener))
                {
                    _onSyncListener._OnSynced(TestName, Variable, $"{byteCount} B");
                }
            }
            else
            {
                RequestSerialization();
            }
        }

        public void _RequestSync( NetworkTrafficBenchmark listener )
        {
            _onSyncListener = listener;
            
            Debug.Log( $"{gameObject.name} TestName:{TestName} _RequestSync" );
            
            if (!Networking.IsOwner(gameObject))
            {
                Networking.SetOwner(Networking.LocalPlayer, gameObject);
            }
            
            RequestSerialization();
            
#if UNITY_EDITOR
            Debug.Log( $"{gameObject.name} TestName:{TestName} テストはVRChat上でのみ可能です" );
#endif
        }
    }
}