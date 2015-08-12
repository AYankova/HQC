namespace CompareSortAlgorithms
{
    using System;
    using System.Diagnostics;

    internal class CompareSortAlgorithmsHelper
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        internal static void MeasurePerformanceInsertionSort<T>(T[] arr) where T : IComparable
        {
            Stopwatch.Start();
            SortingAlgorithms.InsertionSort(arr);
            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void MeasurePerformanceSelectionSort<T>(T[] arr) where T : IComparable
        {
            Stopwatch.Start();
            SortingAlgorithms.SelectionSort(arr);
            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }

        internal static void MeasurePerformanceQuickSort<T>(T[] arr) where T : IComparable
        {
            Stopwatch.Start();
            SortingAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", typeof(T).UnderlyingSystemType.Name, Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
