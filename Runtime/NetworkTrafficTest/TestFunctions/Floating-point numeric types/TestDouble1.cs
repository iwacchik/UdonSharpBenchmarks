using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestDouble1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private double double1;

    public override string TestName => "TestDouble";
    protected override int Variable => 1;
}