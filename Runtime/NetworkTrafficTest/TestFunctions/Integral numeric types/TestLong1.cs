using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestLong1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private long long1;

    public override string TestName => "TestLong";
    protected override int Variable => 1;
}