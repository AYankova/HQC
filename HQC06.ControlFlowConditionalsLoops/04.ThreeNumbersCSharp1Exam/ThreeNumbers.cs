namespace ThreeNumbersCSharp1Exam
{
    using System;
    using System.Linq;

    public class ThreeNumbers
    {
        public static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());

            long maxNumber = MaxOfNumbers(firstNumber, secondNumber, thirdNumber);
            long minNumber = MinOfNumbers(firstNumber, secondNumber, thirdNumber);
            decimal averageOfNumbers = AverageOfNumbers(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
            Console.WriteLine("{0:F2}", averageOfNumbers);
        }

        public static long MaxOfNumbers(params long[] numbers)
        {
            return numbers.Max();
        }

        public static long MinOfNumbers(params long[] numbers)
        {
            return numbers.Min();
        }

        public static decimal AverageOfNumbers(params long[] numbers)
        {
            return (decimal)numbers.Average();
        }
    }
}
