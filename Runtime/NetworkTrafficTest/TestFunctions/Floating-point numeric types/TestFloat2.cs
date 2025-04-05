using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestFloat2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private float float1;
    [UdonSynced(UdonSyncMode.None)] private float float2;

    public override string TestName => "TestFloat";
    protected override int Variable => 2;
}