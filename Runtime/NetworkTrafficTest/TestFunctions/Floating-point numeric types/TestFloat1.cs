using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestFloat1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private float float1;

    public override string TestName => "TestFloat";
    protected override int Variable => 1;
}