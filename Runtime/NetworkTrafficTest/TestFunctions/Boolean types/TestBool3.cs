using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestBool3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private bool bool1;
    [UdonSynced(UdonSyncMode.None)] private bool bool2;
    [UdonSynced(UdonSyncMode.None)] private bool bool3;

    public override string TestName => "TestBool";
    protected override int Variable => 3;
}