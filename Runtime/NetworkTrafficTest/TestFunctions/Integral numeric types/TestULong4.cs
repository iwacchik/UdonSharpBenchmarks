using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestULong4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private ulong ulong1;
    [UdonSynced(UdonSyncMode.None)] private ulong ulong2;
    [UdonSynced(UdonSyncMode.None)] private ulong ulong3;
    [UdonSynced(UdonSyncMode.None)] private ulong ulong4;

    public override string TestName => "TestULong";
    protected override int Variable => 4;
}