namespace Methods
{
    using System;
    
    /// <summary>
    /// A class that tests the <see cref="Methods"/> class.
    /// </summary>
    public class MethodsTest
    {
        /// <summary>
        /// A method that tests the methods in <see cref="Methods"/> class.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.DigitToWord(5));

            Console.WriteLine(Methods.FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintNumberWithSelectedFormatOption(1.3, Methods.FormatOptions.RoundToSecondDigit);
            Methods.PrintNumberWithSelectedFormatOption(0.75, Methods.FormatOptions.Percentage);
            Methods.PrintNumberWithSelectedFormatOption(2.30, Methods.FormatOptions.RightAlignment);

            double firstPointX = 3;
            double firstPointY = -1;
            double secondPointX = 3;
            double secondPointY = 2.5;
            double distance = Methods.CalculateDistanceBetweenTwoPoints(firstPointX, firstPointY, secondPointX, secondPointY);

            Console.WriteLine(distance);

            bool horizontal = Methods.FormHorizontalLine(firstPointX, secondPointX);
            bool vertical = Methods.FormVerticalLine(firstPointY, secondPointY);

            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }
    }
}