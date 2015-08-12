namespace ConsoleApplication1CSharp1Exam
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConsoleApplication1
    {
        public static void Main()
        {
            const string ExitInputMode = "END";
            string input = Console.ReadLine();
            List<BigInteger> numbers = new List<BigInteger>();

            while (input != ExitInputMode)
            {
                numbers.Add(BigInteger.Parse(input));
                input = Console.ReadLine();
            }

            if (numbers.Count < 10)
            {
                BigInteger product = 1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        product = ProductOfOdds(numbers, product, i);
                    }
                }

                Console.WriteLine(product);
            }
            else
            {
                BigInteger productOfFirst10Elements = 1;
                BigInteger productOfTheElementsAfter10th = 1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i < 10)
                    {
                        productOfFirst10Elements = ProductOfOdds(numbers, productOfFirst10Elements, i);
                    }
                    else
                    {
                        if (IsOdd(i))
                        {
                            productOfTheElementsAfter10th = ProductOfOdds(numbers, productOfTheElementsAfter10th, i);
                        }
                    }
                }

                Console.WriteLine(productOfFirst10Elements);
                Console.WriteLine(productOfTheElementsAfter10th);
            }
        }

        private static bool IsOdd(BigInteger number)
        {
            return number % 2 != 0;
        }

        private static BigInteger ProductOfOdds(List<BigInteger> numbers, BigInteger product, int i)
        {
            if (IsOdd(i))
            {
                BigInteger currentProduct = 1;

                while (numbers[i] > 0)
                {
                    int currentDigit = (int)(numbers[i] % 10);

                    if (currentDigit != 0)
                    {
                        currentProduct *= currentDigit;
                    }

                    numbers[i] /= 10;
                }

                product *= currentProduct;
            }

            return product;
        }
    }
}