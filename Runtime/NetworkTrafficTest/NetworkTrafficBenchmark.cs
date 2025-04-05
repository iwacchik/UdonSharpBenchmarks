using IwacchiLab.Benchmarks.Network;
using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDK3.Data;
using VRC.SDKBase;

namespace IwacchiLab.Benchmarks.Network
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class NetworkTrafficBenchmark : UdonSharpBehaviour
    {
        [SerializeField] private TMP_Text _resultText;
        [SerializeField] private Image _backgroud;

        [SerializeField] private Color backgroundColor = Color.black;
        [SerializeField] private Color textColor = Color.cyan;
        [SerializeField] private string[] _columnNames;

        [SerializeField] private GameObject _testsRoot;
        [SerializeField] private TrafficTestFunction[] _tests;

        private DataList _results = new DataList();
        private bool _isDirty = false;
        private DataList _columnHeader = new DataList();
        private DataList _columnTemplate = new DataList();
        // private string _resultsTemplate;

        private void Start()
        {
            if (_tests.Length == 0)
            {
                _tests = _testsRoot.GetComponentsInChildren<TrafficTestFunction>();
            }

            for (int i = 0, n = _columnNames.Length; i < n; i++)
            {
                _columnHeader.Add(_columnNames[i]);
                _columnTemplate.Add("-");
            }

            _results.Add(_columnHeader);
            foreach (var test in _tests)
            {
                AddContent(test.TestName);
            }
            //
            // if (VRCJson.TrySerializeToJson(_results, JsonExportType.Minify, out DataToken json))
            // {
            //     _resultsTemplate = json.String;
            // }
        }

        private void Update()
        {
            if (_isDirty)
            {
                UpdateResultView();
                _isDirty = false;
            }
        }

        public override void Interact()
        {
            if (Utilities.IsValid(_tests) && _tests.Length > 0)
            {
                _results.Clear();
                _results.Add(_columnHeader);
                foreach (var test in _tests)
                {
                    AddContent(test.TestName);
                }

                foreach (var test in _tests)
                {
                    test._RequestSync(this);
                }
            }
        }

        public void _OnSynced(string testType, int index, string result)
        {
            // 0はRowHeader
            if (index == 0)
            {
                return;
            }

            for (int i = 0, n = _results.Count; i < n; i++)
            {
                var content = _results[i].DataList;
                if (content[0] == testType && index < content.Count)
                {
                    content[index] = result;
                    _isDirty = true;
                    break;
                }
            }
        }

        private void AddContent(string testType)
        {
            for (int i = 0, n = _results.Count; i < n; i++)
            {
                if (i != 0 && _results[i].DataList[0].String == testType)
                {
                    break;
                }

                if (i == n - 1)
                {
                    var newContent = _columnTemplate.DeepClone();
                    newContent[0] = testType;
                    _results.Add(newContent);
                    _isDirty = true;
                }
            }
        }

        private void UpdateResultView()
        {
            _resultText.text = TableText.Create(_results);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (Utilities.IsValid(_backgroud))
            {
                _backgroud.color = backgroundColor;
            }

            if (Utilities.IsValid(_resultText))
            {
                _resultText.color = textColor;
            }
        }
#endif
    }
}