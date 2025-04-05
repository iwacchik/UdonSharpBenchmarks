
using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestBool1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private bool bool1;

    public override string TestName => "TestBool";
    protected override int Variable => 1;
}
