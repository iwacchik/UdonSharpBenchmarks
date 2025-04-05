using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector43 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector41;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector42;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector43;

    public override string TestName => "TestVector4";
    protected override int Variable => 3;
}