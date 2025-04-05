using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUInt4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private uint uint1;
    [UdonSynced(UdonSyncMode.None)] private uint uint2;
    [UdonSynced(UdonSyncMode.None)] private uint uint3;
    [UdonSynced(UdonSyncMode.None)] private uint uint4;

    public override string TestName => "TestUInt";
    protected override int Variable => 4;
}