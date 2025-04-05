using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector32 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector31;
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector32;

    public override string TestName => "TestVector3";
    protected override int Variable => 2;
}