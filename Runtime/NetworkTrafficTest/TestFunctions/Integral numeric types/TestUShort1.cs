using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestUShort1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private ushort ushort1;

    public override string TestName => "TestUShort";
    protected override int Variable => 1;
}