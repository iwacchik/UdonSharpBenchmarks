using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestFloat3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private float float1;
    [UdonSynced(UdonSyncMode.None)] private float float2;
    [UdonSynced(UdonSyncMode.None)] private float float3;

    public override string TestName => "TestFloat";
    protected override int Variable => 3;
}