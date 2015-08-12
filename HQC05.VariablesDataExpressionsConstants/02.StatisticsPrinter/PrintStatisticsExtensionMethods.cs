namespace StatisticsPrinter
{
    using System;
    using System.Linq;
    using System.Text;

    public static class PrintStatisticsExtensionMethods
    {
        public static void PrintStatistics(this double[] numbers)
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Min number: {0}", numbers.GetMin());
            result.AppendLine();
            result.AppendFormat("Max number: {0}", numbers.GetMax());
            result.AppendLine();
            result.AppendFormat("Average of numbers: {0:F2}", numbers.GetAverage());

            Console.WriteLine(result);
        }

        public static double GetMin(this double[] numbers)
        {
            double min = double.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static double GetMax(this double[] numbers)
        {
            double max = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public static double GetAverage(this double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }
    }
}
