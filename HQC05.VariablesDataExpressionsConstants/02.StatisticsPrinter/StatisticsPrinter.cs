namespace StatisticsPrinter
{
    using System;

    public class StatisticsPrinter
    {
        public static void Main()
        {
            double[] numbers = new double[] { 1.8, 3.4, -16.2, 0, 3.9, -5.2, -11.2, 17.3, 2.9 };

            numbers.PrintStatistics();
        }
    }
}
