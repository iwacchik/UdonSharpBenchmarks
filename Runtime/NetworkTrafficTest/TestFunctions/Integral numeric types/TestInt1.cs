using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestInt1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private int int1;

    public override string TestName => "TestInt";
    protected override int Variable => 1;
}