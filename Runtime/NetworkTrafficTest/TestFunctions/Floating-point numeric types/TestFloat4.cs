﻿using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestFloat4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private float float1;
    [UdonSynced(UdonSyncMode.None)] private float float2;
    [UdonSynced(UdonSyncMode.None)] private float float3;
    [UdonSynced(UdonSyncMode.None)] private float float4;

    public override string TestName => "TestFloat";
    protected override int Variable => 4;
}