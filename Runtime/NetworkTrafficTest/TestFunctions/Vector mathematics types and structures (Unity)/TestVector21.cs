using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestVector21 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private Vector2 vector21;

    public override string TestName => "TestVector2";
    protected override int Variable => 1;
}