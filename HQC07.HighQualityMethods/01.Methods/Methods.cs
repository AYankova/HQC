namespace Methods
{
    using System;

    /// <summary>
    /// A class that provides methods for calculating the area of a triangle, calculating the distance between 2 points, converting digit to a
    /// word, finding the maximal number in an array and printing a number by formatting options.
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// Formatting options used when printing a number .
        /// </summary>
        public enum FormatOptions
        {
            /// <summary>
            /// An option for printing the number to the second digit.
            /// </summary>
            RoundToSecondDigit = 1,

            /// <summary>
            /// An option for printing the number as a percentage.
            /// </summary>
            Percentage = 2,

            /// <summary>
            /// An option for printing the number with right alignment. 
            /// </summary>
            RightAlignment = 3
        }

        /// <summary>
        /// The method calculates the area of a triangle by given three sides.
        /// </summary>
        /// <param name="firstSide">First side of the triangle.</param>
        /// <param name="secondSide">Second side of the triangle.</param>
        /// <param name="thirdSide">Third side of the triangle.</param>
        /// <returns>Double value - the area of the triangle.</returns>
        public static double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides of the triangle should be positive numbers.");
            }

            if (!IsTriangle(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentException("These three sides can't form a triangle.");
            }

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            // Calculating the area of the triangle using Heron's formula
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));

            return area;
        }

        /// <summary>
        /// The method converts a digit to word.
        /// </summary>
        /// <param name="number">Integer value - the digit which is passed to be converted.</param>
        /// <returns>String - the digit as a word.</returns>
        public static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit.");
            }
        }

        /// <summary>
        /// The method finds the maximal element of given integers.
        /// </summary>
        /// <param name="elements">Integer values to be compared.</param>
        /// <returns>The maximal number of the integers passed.</returns>
        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("No arguments passed.");
            }

            int maxNumber = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        /// <summary>
        /// The method prints on the console a number in the chosen format.
        /// </summary>
        /// <param name="number">Input number passed for formatting.</param>
        /// <param name="format">Input string that specifies the type of formatting.</param>
        public static void PrintNumberWithSelectedFormatOption(object number, FormatOptions format)
        {
            switch (format)
            {
                case FormatOptions.RoundToSecondDigit:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case FormatOptions.Percentage:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case FormatOptions.RightAlignment:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid formattiong option.");
            }
        }

        /// <summary>
        /// The method calculates the distance between two points.
        /// </summary>
        /// <param name="coordXFirstPoint">The first point coordinate on the abscissa.</param>
        /// <param name="coordYFirstPoint">The first point coordinate on the ordinate.</param>
        /// <param name="coordXSecondPoint">The second point coordinate on the abscissa.</param>
        /// <param name="coordYSecondPoint">The second point coordinate on the ordinate.</param>
        /// <returns>Double value - the distance between the two points.</returns>
        public static double CalculateDistanceBetweenTwoPoints(double coordXFirstPoint, double coordYFirstPoint, double coordXSecondPoint, double coordYSecondPoint)
        {
            double productOfAbscissaCoordinates = (coordXSecondPoint - coordXFirstPoint) * (coordXSecondPoint - coordXFirstPoint);
            double productOfOrdinateCoordinates = (coordYSecondPoint - coordYFirstPoint) * (coordYSecondPoint - coordYFirstPoint);
            double distance = Math.Sqrt(productOfAbscissaCoordinates + productOfOrdinateCoordinates);

            return distance;
        }

        /// <summary>
        /// A method that checks if two points lie on a straight horizontal line.
        /// </summary>
        /// <param name="coordXFirstPoint">The coordinate on the abscissa of the first point.</param>
        /// <param name="coordXSecondPoint">The coordinate on the abscissa of the second point.</param>
        /// <returns>Boolean value - true if the two points form a horizontal line and false - otherwise.</returns>
        public static bool FormHorizontalLine(double coordXFirstPoint, double coordXSecondPoint)
        {
            return coordXFirstPoint == coordXSecondPoint;
        }

        /// <summary>
        /// A method that checks if two points lie on a straight vertical line.
        /// </summary>
        /// <param name="coordYFirstPoint">The coordinate on the ordinate of the first point.</param>
        /// <param name="coordYSecondPoint">The coordinate on the ordinate of the second point.</param>
        /// <returns>Boolean value - true if the two points form a vertical line and false - otherwise.</returns>
        public static bool FormVerticalLine(double coordYFirstPoint, double coordYSecondPoint)
        {
            return coordYFirstPoint == coordYSecondPoint;
        }

        /// <summary>
        /// The method checks whether three lines can form a triangle.
        /// </summary>
        /// <param name="firstSide">Double value of the first line.</param>
        /// <param name="secondSide">Double value of the second line.</param>
        /// <param name="thirdSide">Double value of the third line.</param>
        /// <returns>Boolean value - true if the lines can form a triangle and false - otherwise.</returns>
        private static bool IsTriangle(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide + secondSide > thirdSide) && (secondSide + thirdSide > firstSide) && (firstSide + thirdSide > secondSide);
        }
    }
}