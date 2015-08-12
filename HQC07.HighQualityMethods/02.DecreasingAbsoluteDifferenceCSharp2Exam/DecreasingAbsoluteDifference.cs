namespace DecreasingAbsoluteDifferenceCSharp2Exam
{
    using System;
    using System.Linq;
    using System.Text;

    public class DecreasingAbsoluteDifference
    {
        public static void Main()
        {
            int numberofSequences = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numberofSequences; i++)
            {
                long[] numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();

                output.AppendLine(IsDecreasing(numbers).ToString());
            }

            Console.WriteLine(output.ToString().TrimEnd());
        }

        /// <summary>
        /// A method that checks if the elements of an array are decreasing.
        /// </summary>
        /// <param name="numbers">The input array of type long.</param>
        /// <returns>Boolean value - true if the elements of the array are decreasing and false - otherwise.</returns>
        private static bool IsDecreasing(long[] numbers)
        {
            if (numbers.Length <= 2)
            {
                return true;
            }

            long lastNumber = Math.Abs(numbers[1] - numbers[0]);

            for (int i = 2; i < numbers.Length; i++)
            {
                long difference = Math.Abs(numbers[i] - numbers[i - 1]);

                if (lastNumber - difference != 1 && lastNumber - difference != 0)
                {
                    return false;
                }

                lastNumber = difference;
            }

            return true;
        }
    }
}
