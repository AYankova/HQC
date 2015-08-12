namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal static class SortingUtils
    {
        internal static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null!");
            Debug.Assert(arr.Length > 0, "Array is empty!");

            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index is out of range!");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "End index is out of range!");
            Debug.Assert(startIndex <= endIndex, "Start index is greater than end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(minElementIndex >= 0 && minElementIndex < arr.Length, "Out of range min element index!");
            Debug.Assert(minElementIndex == AssertionUtils.IndexOfMinNumber(arr, startIndex, endIndex), "Wrong min element index!");

            return minElementIndex;
        }

        internal static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "First value to swap is null!");
            Debug.Assert(y != null, "Second value to swap is null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
