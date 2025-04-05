using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestQuaternion1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Quaternion quaternion1;
    
    public override string TestName => "TestQuaternion";
    protected override int Variable => 1;

}