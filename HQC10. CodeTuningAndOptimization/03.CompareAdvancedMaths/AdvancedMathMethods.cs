namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    internal static class AdvancedMathMethods
    {
        private const int RepetitionCycles = 1000000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        internal static void SquareRoot(dynamic value)
        {
            dynamic result = value;

            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result = Math.Sqrt((double)value);
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", value.GetType().Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void NaturalLogarithm(dynamic value)
        {
            dynamic result = value;

            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result = Math.Log((double)value);
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", value.GetType().Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void Sinus(dynamic value)
        {
            dynamic result = value;

            Stopwatch.Start();

            for (int i = 0; i < RepetitionCycles; i++)
            {
                result = Math.Sin((double)value);
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", value.GetType().Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
