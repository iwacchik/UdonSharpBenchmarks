using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector34 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector31;
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector32;
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector33;
    [UdonSynced(UdonSyncMode.None)] private Vector3 vector34;

    public override string TestName => "TestVector3";
    protected override int Variable => 4;
}