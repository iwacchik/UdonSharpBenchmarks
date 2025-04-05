using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUInt1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private uint uint1;

    public override string TestName => "TestUInt";
    protected override int Variable => 1;
}