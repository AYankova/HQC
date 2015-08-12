namespace BooleanToStringConverter
{
    using System;

    public class BooleanToStringPrinter
    {
        public static void Main()
        {
            BooleanToStringConverter converter = new BooleanToStringConverter();
            var trueAsString = BooleanToStringConverter.Convert(true);
            var falseAsString = BooleanToStringConverter.Convert(false);

            Console.WriteLine(trueAsString);
            Console.WriteLine(falseAsString);
        }
    }
}