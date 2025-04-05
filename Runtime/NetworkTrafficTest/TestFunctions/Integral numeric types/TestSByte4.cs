using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestSByte4 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte1;
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte2;
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte3;
    [UdonSynced(UdonSyncMode.None)] private sbyte sbyte4;

    public override string TestName => "TestSByte";
    protected override int Variable => 4;
}