using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestSByte2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte1;
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte2;

    public override string TestName => "TestSByte";
    protected override int Variable => 2;
}