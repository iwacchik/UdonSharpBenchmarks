
using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestBool2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private bool bool1;
    [UdonSynced(UdonSyncMode.None)] private bool bool2;

    public override string TestName => "TestBool";
    protected override int Variable => 2;
}
