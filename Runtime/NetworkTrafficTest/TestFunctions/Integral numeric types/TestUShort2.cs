using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUShort2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private ushort ushort1;
    [UdonSynced(UdonSyncMode.None)] private ushort ushort2;

    public override string TestName => "TestUShort";
    protected override int Variable => 2;
}