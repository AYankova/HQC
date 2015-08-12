namespace CompareAdvancedMaths
{
    using System;

    public class CompareAdvancedMathsTests
    {
        public static void Main()
        {
            float floatValue = 100.0f;
            double doubleValue = 100.0;
            decimal decimalValue = 100.0m;

            Console.WriteLine("Square Root:");
            Console.WriteLine(new string('*', 40));
            AdvancedMathMethods.SquareRoot(floatValue);
            AdvancedMathMethods.SquareRoot(doubleValue);
            AdvancedMathMethods.SquareRoot(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Natural logarithm:");
            Console.WriteLine(new string('*', 40));
            AdvancedMathMethods.NaturalLogarithm(floatValue);
            AdvancedMathMethods.NaturalLogarithm(doubleValue);
            AdvancedMathMethods.NaturalLogarithm(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Sinus:");
            Console.WriteLine(new string('*', 40));
            AdvancedMathMethods.Sinus(floatValue);
            AdvancedMathMethods.Sinus(doubleValue);
            AdvancedMathMethods.Sinus(decimalValue);
            Console.WriteLine(new string('*', 40));
        }
    }
}
