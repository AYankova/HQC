namespace RotatingWalkInMatrix
{
    using System;

    public class InputUtils
    {
        public static int ReadMatrixSize()
        {
            string input;
            int size;

            do
            {
                Console.WriteLine("Enter size of the matrix, an integer number between {0} and {1} inclusive!", Matrix.MinSize, Matrix.MaxSize);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out size) || !IsInRange(size));

            return size;
        }

        private static bool IsInRange(int size)
        {
            bool isHigherOrEqualToMinValue = size >= Matrix.MinSize;
            bool isLowerOrEqualToMaxValue = size <= Matrix.MaxSize;

            return isHigherOrEqualToMinValue && isLowerOrEqualToMaxValue;
        }
    }
}
