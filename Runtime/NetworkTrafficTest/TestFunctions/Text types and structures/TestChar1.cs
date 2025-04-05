using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestChar1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private char char1;

    public override string TestName => "TestChar";
    protected override int Variable => 1;
}