using System;
using System.Diagnostics;

namespace Exercises.Performance
{
    public class Step : IDisposable
    {
        private readonly string _name;
        private readonly Stopwatch _sw;

        public Step(string name)
        {
            _name = name;
            _sw = new Stopwatch();
            _sw.Start();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _sw.Stop();
            Console.WriteLine($"=== Step '{_name}' took {_sw.Elapsed}");
        }
    }
}
