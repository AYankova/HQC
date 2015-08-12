namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static void Main()
        {
            var substr = ExtensionMethods.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = ExtensionMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = ExtensionMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = ExtensionMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtensionMethods.ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtensionMethods.ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtensionMethods.ExtractEnding("beer", 4));

            // Console.WriteLine(ExtensionMethods.ExtractEnding("Hi", 100));
            try
            {
                Console.WriteLine(ExtensionMethods.ExtractEnding("Hi", 100));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message:");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("23 is prime? --> {0}", ExtensionMethods.CheckPrime(23));
            Console.WriteLine("33 is prime? --> {0}", ExtensionMethods.CheckPrime(33));

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}