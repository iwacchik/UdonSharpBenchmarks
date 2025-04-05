using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestChar3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private char char1;
    [UdonSynced(UdonSyncMode.None)] private char char2;
    [UdonSynced(UdonSyncMode.None)] private char char3;

    public override string TestName => "TestChar";
    protected override int Variable => 3;
}