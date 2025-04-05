using UnityEngine;
using VRC.SDKBase;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public class NullCheckBenchmark : BenchmarkRunnerBase
    {
        private GameObject[] _testObjects;

        protected override void Initialize()
        {
            _testObjects = new GameObject[_iterations];
            for (int i = 0; i < _iterations; i++)
            {
                _testObjects[i] = (i % 2) == 0 ? gameObject : null;
            }
        }

        public void NullCheck_Equality()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (_testObjects[i] == null)
                {
                }
                else
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void NullCheck_Inequality()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (_testObjects[i] != null)
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void NullCheck_Equality_Continue()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (_testObjects[i] == null)
                {
                    continue;
                }

                test++;
            }
            _stopwatch.Stop();
        }

        public void UseIsValid()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (Utilities.IsValid(_testObjects[i]))
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void UseIsValid_Negative()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (!Utilities.IsValid(_testObjects[i]))
                {
                }
                else
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void UseIsValid_Negative_UseContinue()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (!Utilities.IsValid(_testObjects[i]))
                {
                    continue;
                }

                test++;
            }
            _stopwatch.Stop();
        }

        public void PlayerNullCheck()
        {
            var localPlayer = Networking.LocalPlayer;
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (localPlayer == null)
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void PlayerUtilitiesIsValid()
        {
            var localPlayer = Networking.LocalPlayer;
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (!Utilities.IsValid(localPlayer))
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void PlayerIsValid()
        {
            var localPlayer = Networking.LocalPlayer;
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (!localPlayer.IsValid())
                {
                    test++;
                }
            }
            _stopwatch.Stop();
        }

        public void GameObjectNullCheck()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (gameObject != null)
                {
                }
            }
            _stopwatch.Stop();
        }

        /// <summary>
        /// 演算子消すと早くなる検証
        /// </summary>
        public void GameObjectNullCheckNoOperator()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (gameObject)
                {
                }
            }
            _stopwatch.Stop();
        }

        public void GameObjectIsValid()
        {
            var test = 0;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (Utilities.IsValid(gameObject))
                {
                }
            }
            _stopwatch.Stop();
        }

        /// <summary>
        /// bool保持すると早くなる検証
        /// </summary>
        public void Fastest()
        {
            var test = 0;
            var exists = Utilities.IsValid(gameObject);
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (exists)
                {
                }
            }
            _stopwatch.Stop();
        }

        /// <summary>
        /// nullを事前に宣言すると早くなる説の検証
        /// </summary>
        public void Fastest2()
        {
            var test = 0;
            GameObject nullCheck = null;
            _stopwatch.Restart();
            for (int i = 0; i < _iterations; i++)
            {
                if (gameObject != nullCheck)
                {
                }
            }
            _stopwatch.Stop();
        }

        //
        // public void UseIsValid_Equality()
        // {
        //     GameObject go = null;
        //     
        //     _stopwatch.Restart();
        //     for (int i = 0; i < _iterations; i++)
        //         if (Utilities.IsValid(go) == true) { }
        //     _stopwatch.Stop();
        // }
        //
        // public void UseIsValid_Inequality()
        // {
        //     GameObject go = null;
        //
        //     _stopwatch.Restart();
        //     for (int i = 0; i < _iterations; i++)
        //         if (Utilities.IsValid(go) == false) { }
        //     _stopwatch.Stop();
        // }
    }
}