using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector42 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector41;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector42;

    public override string TestName => "TestVector4";
    protected override int Variable => 2;
}