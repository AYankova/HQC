namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    internal static class OperationMethods
    {
        private const int RepetitionCycles = 1000000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        internal static void Addition<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result += value;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void Substraction<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result -= value;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void Division<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result /= value;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void Multiplication<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result *= value;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void PostIncrement<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result++;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void PreIncrement<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                ++result;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void IncrementPlusEqualToOne<T>(T value) where T : IComparable
        {
            dynamic result = value;
            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result += 1;
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
