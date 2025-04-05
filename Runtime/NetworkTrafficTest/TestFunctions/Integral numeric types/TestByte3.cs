using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestByte3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private byte byte1;
    [UdonSynced(UdonSyncMode.None)] private byte byte2;
    [UdonSynced(UdonSyncMode.None)] private byte byte3;

    public override string TestName => "TestByte";
    protected override int Variable => 3;
}