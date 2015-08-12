namespace RotatingWalkInMatrix
{
    using System;

    public class RotatingWalkInMatrixDemo
    {
        public static void Main(string[] args)
        {
            int size = InputUtils.ReadMatrixSize();
            SquareMatrix matrix = new SquareMatrix(size);
            matrix.FillMatrix();
            Console.WriteLine(matrix);
        }
    }
}