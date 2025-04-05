using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestByte2 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private byte byte1;
    [UdonSynced(UdonSyncMode.None)] private byte byte2;

    public override string TestName => "TestByte";
    protected override int Variable => 2;
}