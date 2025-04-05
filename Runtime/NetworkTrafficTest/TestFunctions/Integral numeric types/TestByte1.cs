using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestByte1 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private byte byte1;

    public override string TestName => "TestByte";
    protected override int Variable => 1;
}