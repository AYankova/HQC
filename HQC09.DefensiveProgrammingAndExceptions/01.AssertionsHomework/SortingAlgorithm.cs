namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;

    public static class SortingAlgorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null!");
            Debug.Assert(arr.Length > 0, "Array is empty!");

            int len = arr.Length;
            for (int index = 0; index < len - 1; index++)
            {
                int minElementIndex = SortingUtils.FindMinElementIndex(arr, index, arr.Length - 1);
                SortingUtils.Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(arr.Length == len, "Input and output arrays are of a different size!");
            Debug.Assert(AssertionUtils.IsSorted(arr), "Array is not sorted!");
        }
    }
}
