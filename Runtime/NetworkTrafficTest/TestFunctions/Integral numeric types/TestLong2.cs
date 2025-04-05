using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestLong2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private long long1;
    [UdonSynced(UdonSyncMode.None)] private long long2;

    public override string TestName => "TestLong";
    protected override int Variable => 2;
}