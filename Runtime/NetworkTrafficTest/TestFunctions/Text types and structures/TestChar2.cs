using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestChar2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private char char1;
    [UdonSynced(UdonSyncMode.None)] private char char2;

    public override string TestName => "TestChar";
    protected override int Variable => 2;
}