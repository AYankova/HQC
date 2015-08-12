namespace RotatingWalkInMatrix.Test
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RotatingWalkTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixShouldThrowAnExceptionWhenTryingToSetRowsAValueLessThanTheMinValue()
        {
            var matrix = new Matrix(0, 15);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixShouldThrowAnExceptionWhenTryingToSetRowsAValueGreaterThanTheMaxValue()
        {
            var matrix = new Matrix(101, 15);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixShouldThrowAnExceptionWhenTryingToSetColsAValueLessThanTheMinValue()
        {
            var matrix = new Matrix(15, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixShouldThrowAnExceptionWhenTryingToSetColsAValueGreaterThanTheMaxValue()
        {
            var matrix = new Matrix(15, 101);
        }

        [Test]
        public void MatrixShouldNotThrowAnExceptionWhenTryingToSetValidRowsAndCols()
        {
            var matrix = new Matrix(1, 100);
        }

        [Test]
        public void SquareMatrixShouldNotThrowAnExceptionWhenTryingToSetValidSize()
        {
            var matrix = new SquareMatrix(50);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SquareMatrixShouldThrowAnExceptionWhenTryingToSetInvalidSize()
        {
            var matrix = new SquareMatrix(500);
        }

        [Test]
        public void SquareMatrixShouldReturnCorrectMatrixOfSizeOne()
        {
            var matrix = new SquareMatrix(1);
            matrix.FillMatrix();

            Assert.AreEqual("    1\r\n", matrix.ToString(), "Traversing 1x1 matrix is incorrect.");
        }

        [Test]
        public void SquareMatrixShouldReturnCorrectMatrixOfSizeTwo()
        {
            var matrix = new SquareMatrix(2);
            matrix.FillMatrix();

            Assert.AreEqual("    1    4\r\n    3    2\r\n", matrix.ToString(), "Traversing 2x2 matrix is incorrect.");
        }

        [Test]
        public void SquareMatrixShouldReturnCorrectMatrixOfSizeThree()
        {
            var matrix = new SquareMatrix(3);
            matrix.FillMatrix();

            Assert.AreEqual("    1    7    8\r\n    6    2    9\r\n    5    4    3\r\n", matrix.ToString(), "Traversing 3x3 matrix is incorrect.");
        }

        public void SquareMatrixShouldReturnCorrectMatrixOfSizeSix()
        {
            var matrix = new SquareMatrix(6);
            matrix.FillMatrix();

            Assert.AreEqual(
            "    1   16   17   18   19   20\r\n" +
            "   15    2   27   28   29   21\r\n" +
            "   14   31    3   26   30   22\r\n" +
            "   13   36   32    4   25   23\r\n" +
            "   12   35   34   33    5   24\r\n" +
            "   11   10    9    8    7    6",
            matrix.ToString(), 
            "Traversing 6x6 matrix is incorrect.");
        }
    }
}
