using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestQuaternion4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion1;
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion2;
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion3;
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion4;
    
    public override string TestName => "TestQuaternion";
    protected override int Variable => 4;
}