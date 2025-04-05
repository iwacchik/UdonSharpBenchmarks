using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector31 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector31;

    public override string TestName => "TestVector3";
    protected override int Variable => 1;
}