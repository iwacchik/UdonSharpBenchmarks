using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUInt2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private uint uint1;
    [UdonSynced(UdonSyncMode.None)] private uint uint2;

    public override string TestName => "TestUInt";
    protected override int Variable => 2;
}