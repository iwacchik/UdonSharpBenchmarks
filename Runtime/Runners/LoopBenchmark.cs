
using UnityEngine;

namespace IwacchiLab.Tester.UdonsharpBenchmarks
{
    public class LoopBenchmark : BenchmarkRunnerBase
    {
        public void ForLoop()
        {
            Debug.Log( $"For Loop {_iterations}" );
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            for (int i = 0; i < array.Length; i++)
            {
                test++;
            }

            _stopwatch.Stop();

            OnComplete();
        }

        public void ForLoop_LengthCache()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            for (int i = 0, n = array.Length; i < n; i++)
            {
                test++;
            }

            _stopwatch.Stop();

            OnComplete();
        }

        public void WhileLoop()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            var i = 0;
            while (i < array.Length)
            {
                test++;
                i++;
            }

            _stopwatch.Stop();

            OnComplete();
        }

        public void WhileLoop_LengthCache()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            var i = 0;
            var n = array.Length;
            while (i < n)
            {
                test++;
                i++;
            }

            _stopwatch.Stop();

            OnComplete();
        }

        public void DoWhileLoop()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            var i = 0;
            do
            {
                test++;
                i++;
            } while (i < array.Length);

            _stopwatch.Stop();

            OnComplete();
        }

        public void DoWhileLoop_LengthCache()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            var i = 0;
            var n = array.Length;
            do
            {
                test++;
                i++;
            } while (i < n);

            _stopwatch.Stop();

            OnComplete();
        }

        public void ForEachLoop()
        {
            var test = 0;
            var array = new int[_iterations];

            _stopwatch.Restart();
            foreach (var v in array)
            {
                test++;
            }

            _stopwatch.Stop();

            OnComplete();
        }


        public void ForLoop_Nothing()
        {
            var test = 0;
            _stopwatch.Restart();
            for (var i = 0; i < _iterations; i++)
            {
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
            }

            _stopwatch.Stop();

            OnComplete();
        }

        public void ForLoop_Continue()
        {
            var test = 0;
            _stopwatch.Restart();
            for (var i = 0; i < _iterations; i++)
            {
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                test++;
                continue;
            }

            _stopwatch.Stop();

            OnComplete();
        }
    }
}