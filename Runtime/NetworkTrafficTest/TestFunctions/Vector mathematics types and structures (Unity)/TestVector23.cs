using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector23 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector2 vector21;
    [UdonSynced(UdonSyncMode.None)] private Vector2 vector22;
    [UdonSynced(UdonSyncMode.None)] private Vector2 vector23;

    public override string TestName => "TestVector2";
    protected override int Variable => 3;
}