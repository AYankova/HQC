namespace RefactoringLoop
{
    using System;

    public class RefactoringLoop
    {
        public static void Main()
        {
            /*
            int i=0;
            for (i = 0; i < 100;) 
            {
               if (i % 10 == 0)
               {
                Console.WriteLine(array[i]);
                if ( array[i] == expectedValue ) 
                {
                   i = 666;
                }
                i++;
               }
               else
               {
                    Console.WriteLine(array[i]);
                i++;
               }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
           */

            int[] numbers = new int[] { 4, 18, 10, -5, 66, 19, 22, 0, 14, 44, 39, 150 };
            int expectedValue = 39;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    int currentValue = numbers[i];

                    if (currentValue == expectedValue)
                    {
                        Console.WriteLine("Value found!");
                        break;
                    }
                }

                Console.WriteLine(numbers[i]);
            }
        }
    }
}
