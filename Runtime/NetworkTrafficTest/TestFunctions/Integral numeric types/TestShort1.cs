using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestShort1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private short short1;

    public override string TestName => "TestShort";
    protected override int Variable => 1;
}