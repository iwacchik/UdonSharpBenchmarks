using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestULong1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private ulong ulong1;

    public override string TestName => "TestULong";
    protected override int Variable => 1;
}