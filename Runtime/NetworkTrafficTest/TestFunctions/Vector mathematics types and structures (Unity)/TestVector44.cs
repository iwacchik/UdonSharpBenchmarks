using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector44 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector41;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector42;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector43;
    [UdonSynced(UdonSyncMode.None)] private Vector4 vector44;

    public override string TestName => "TestVector4";
    protected override int Variable => 4;
}