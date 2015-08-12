namespace CompareSimpleMaths
{
    using System;

    public class CompareSimpleMathsTest
    {
        public static void Main()
        {
            int intValue = 1;
            long longValue = 1L;
            float floatValue = 1.0f;
            double doubleValue = 1.0;
            decimal decimalValue = 1.0m;

            Console.WriteLine("ADDITION:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.Addition(intValue);
            OperationMethods.Addition(longValue);
            OperationMethods.Addition(floatValue);
            OperationMethods.Addition(doubleValue);
            OperationMethods.Addition(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Substraction:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.Substraction(intValue);
            OperationMethods.Substraction(longValue);
            OperationMethods.Substraction(floatValue);
            OperationMethods.Substraction(doubleValue);
            OperationMethods.Substraction(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Multiplication:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.Multiplication(intValue);
            OperationMethods.Multiplication(longValue);
            OperationMethods.Multiplication(floatValue);
            OperationMethods.Multiplication(doubleValue);
            OperationMethods.Multiplication(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Division:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.Division(intValue);
            OperationMethods.Division(longValue);
            OperationMethods.Division(floatValue);
            OperationMethods.Division(doubleValue);
            OperationMethods.Division(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("PostIncrement:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.PostIncrement(intValue);
            OperationMethods.PostIncrement(longValue);
            OperationMethods.PostIncrement(floatValue);
            OperationMethods.PostIncrement(doubleValue);
            OperationMethods.PostIncrement(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("PreIncrement:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.PreIncrement(intValue);
            OperationMethods.PreIncrement(longValue);
            OperationMethods.PreIncrement(floatValue);
            OperationMethods.PreIncrement(doubleValue);
            OperationMethods.PreIncrement(decimalValue);
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Increment Plus Equal To One:");
            Console.WriteLine(new string('*', 40));
            OperationMethods.IncrementPlusEqualToOne(intValue);
            OperationMethods.IncrementPlusEqualToOne(longValue);
            OperationMethods.IncrementPlusEqualToOne(floatValue);
            OperationMethods.IncrementPlusEqualToOne(doubleValue);
            OperationMethods.IncrementPlusEqualToOne(decimalValue);
            Console.WriteLine(new string('*', 40));
        }
    }
}
