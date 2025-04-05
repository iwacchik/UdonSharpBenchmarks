using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUShort4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private ushort ushort1;
    [UdonSynced(UdonSyncMode.None)] private ushort ushort2;
    [UdonSynced(UdonSyncMode.None)] private ushort ushort3;
    [UdonSynced(UdonSyncMode.None)] private ushort ushort4;

    public override string TestName => "TestUShort";
    protected override int Variable => 4;
}