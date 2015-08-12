namespace CompareSortAlgorithms
{
    using System;

    public class CompareSortAlgorithmsTest
    {
        public static void Main()
        {
            int[] randomInt = new int[] { 5, 8, 3, 9, 2, 4, 1, 7, 10, 6 };
            int[] sortedInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reversedInt = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            double[] randomDouble = new double[] { 5.5, 8.8, 3.3, 9.9, 2.2, 4.4, 1.1, 7.7, 10.1, 6.6 };
            double[] sortedDouble = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.1 };
            double[] reversedDouble = new double[] { 10.1, 9.9, 8.8, 7.7, 6.6, 5.5, 4.4, 3.3, 2.2, 1.1 };
            string[] randomStr = new string[] { "bnksnck", "fkmlkmdbl", "hncahndqo", "qjfckwjm", "aokkfdmd", "opckkf", "wmvjjfc", "podqdjkqj", "xkokwwo", "enjnjk" };
            string[] sortedStr = new string[] { "aokkfdmd", "bnksnck", "enjnjk", "fkmlkmdbl", "hncahndqo", "opckkf", "podqdjkqj", "qjfckwjm", "wmvjjfc", "xkokwwo" };
            string[] reversedStr = new string[] { "xkokwwo", "wmvjjfc", "qjfckwjm", "podqdjkqj", "opckkf", "hncahndqo", "fkmlkmdbl", "enjnjk", "bnksnck", "aokkfdmd" };

            Console.WriteLine("***Insertion Sort***");
            Console.WriteLine("*Random*");
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(randomInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(randomDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(randomStr);
            Console.WriteLine("*Sorted*");
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(sortedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(sortedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(sortedStr);
            Console.WriteLine("*Reversed*");
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(reversedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(reversedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceInsertionSort(reversedStr);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("***Selection Sort***");
            Console.WriteLine("*Random*");
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(randomInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(randomDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(randomStr);
            Console.WriteLine("*Sorted*");
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(sortedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(sortedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(sortedStr);
            Console.WriteLine("*Reversed*");
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(reversedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(reversedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceSelectionSort(reversedStr);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("***Quick Sort***");
            Console.WriteLine("*Random*");
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(randomInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(randomDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(randomStr);
            Console.WriteLine("*Sorted*");
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(sortedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(sortedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(sortedStr);
            Console.WriteLine("*Reversed*");
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(reversedInt);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(reversedDouble);
            CompareSortAlgorithmsHelper.MeasurePerformanceQuickSort(reversedStr);
            Console.WriteLine(new string('*', 40));
        }
    }
}
