namespace AssertionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class AssertionUtils
    {
        // taken from http://stackoverflow.com/questions/11989071
        internal static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var y = list.First();
            return list.Skip(1).All(x =>
            {
                bool b = y.CompareTo(x) < 0;
                y = x;
                return b;
            });
        }

        // TODO: generally needs more abstraction, preferably working with IEnumerable<T>. For the purpose of the homework, where methods are 
        // invoked with generic arrays is maybe ok.
        // taken from http://stackoverflow.com/questions/4204169 with small modifications
        internal static int IndexOfMinNumber<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
        {
            return Enumerable.Range(startIndex, endIndex - startIndex + 1)
                .Aggregate((a, b) => (arr[a].CompareTo(arr[b]) < 0) ? a : b);
        }

        // TODO: generally needs more abstraction. Using only LINQ would be a better decision when working with collections. 
        // Just wanted to try out the method Array.Exists
        internal static bool ContainsElement<T>(T[] arr, T value) where T : IComparable<T>
        {
            return Array.Exists(arr, i => i.Equals(value));
        }
    }
}
