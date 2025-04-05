using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestShort2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private short short1;
    [UdonSynced(UdonSyncMode.None)] private short short2;

    public override string TestName => "TestShort";
    protected override int Variable => 2;
}