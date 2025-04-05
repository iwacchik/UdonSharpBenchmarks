using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestQuaternion2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion1;
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion2;
    
    public override string TestName => "TestQuaternion";
    protected override int Variable => 2;
}