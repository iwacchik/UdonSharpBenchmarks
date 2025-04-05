
using IwacchiLab.Benchmarks.Network;
using UdonSharp;
using UnityEngine;

public class TestIntMultipleUdon : TrafficTestFunction
{
    [UdonSynced(UdonSyncMode.None)] private int int1;

    [SerializeField] private string _testName = "";
    [SerializeField] private int _coulumnIndex = 1;
    
    public override string TestName => _testName;
    protected override int Variable => _coulumnIndex;
}
