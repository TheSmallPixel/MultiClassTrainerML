using System;
using System.Diagnostics;

namespace NeuralWebApi.Extension
{
    public static class Metrics
    {
        public static T Look<T>(Func<T> action) {
            Console.WriteLine($"========[{action.Method.Name}]========");
            Stopwatch s = Stopwatch.StartNew();
            T result = action();
            s.Stop();
            Console.WriteLine($"========[{s.ElapsedMilliseconds}]========");
            return result;
        }
        public static void Look(Action action) {
            Console.WriteLine($"========[{action.Method.Name}]========");
            Stopwatch s = Stopwatch.StartNew();
            action();
            s.Stop();
            Console.WriteLine($"========[{s.ElapsedMilliseconds}]========");
            return;
        }
    }
}
