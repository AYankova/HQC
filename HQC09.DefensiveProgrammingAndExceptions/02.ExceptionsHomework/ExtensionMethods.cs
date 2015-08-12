namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   internal static class ExtensionMethods
    {
        internal static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("arr", "Array can't be null!");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException("Start index is out of the boundaries of the array!");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of the subsequent elements can't be negative!", "count");
            }

            if (startIndex + count > arr.Length)
            {
                throw new IndexOutOfRangeException("The length of the subsequence exceeds the size of the array!");
            }

            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        internal static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("input string", "can't be null or empty");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("substring length", "exceeds input string's length");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        internal static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
