using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestLong4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private long long1;
    [UdonSynced(UdonSyncMode.None)] private long long2;
    [UdonSynced(UdonSyncMode.None)] private long long3;
    [UdonSynced(UdonSyncMode.None)] private long long4;

    public override string TestName => "TestLong";
    protected override int Variable => 4;
}