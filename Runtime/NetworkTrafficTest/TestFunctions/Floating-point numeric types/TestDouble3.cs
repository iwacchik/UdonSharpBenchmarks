using IwacchiLab.Benchmarks.Network;
using UdonSharp;

public class TestDouble3 : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private double double1;
    [UdonSynced(UdonSyncMode.None)] private double double2;
    [UdonSynced(UdonSyncMode.None)] private double double3;

    public override string TestName => "TestDouble";
    protected override int Variable => 3;
}