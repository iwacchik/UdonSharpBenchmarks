using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestInt4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private int int1;
    [UdonSynced(UdonSyncMode.None)] private int int2;
    [UdonSynced(UdonSyncMode.None)] private int int3;
    [UdonSynced(UdonSyncMode.None)] private int int4;

    public override string TestName => "TestInt";
    protected override int Variable => 4;
}