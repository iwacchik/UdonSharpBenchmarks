using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestSByte1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte1;

    public override string TestName => "TestSByte";
    protected override int Variable => 1;
}