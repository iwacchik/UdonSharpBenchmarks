using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector41 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector41;

    public override string TestName => "TestVector4";
    protected override int Variable => 1;
}