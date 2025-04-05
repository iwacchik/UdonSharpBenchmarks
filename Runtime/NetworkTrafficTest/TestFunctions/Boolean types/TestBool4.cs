using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestBool4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private bool bool1;
    [UdonSynced(UdonSyncMode.None)] private bool bool2;
    [UdonSynced(UdonSyncMode.None)] private bool bool3;
    [UdonSynced(UdonSyncMode.None)] private bool bool4;

    public override string TestName => "TestBool";
    protected override int Variable => 4;
}