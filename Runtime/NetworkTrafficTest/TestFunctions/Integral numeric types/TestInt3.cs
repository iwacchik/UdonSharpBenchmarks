using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestInt3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private int int1;
    [UdonSynced(UdonSyncMode.None)] private int int2;
    [UdonSynced(UdonSyncMode.None)] private int int3;

    public override string TestName => "TestInt";
    protected override int Variable => 3;
}