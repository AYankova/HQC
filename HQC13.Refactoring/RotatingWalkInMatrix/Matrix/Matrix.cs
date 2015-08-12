namespace RotatingWalkInMatrix
{
    using System;

    public class Matrix
    {
        internal const int MinSize = 1;
        internal const int MaxSize = 100;
        private int rows;
        private int cols;

        public Matrix(int rows)
        {
            this.Rows = rows;
            this.Cols = rows;
        }

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (!this.ValidateDimensions(value))
                {
                    throw new ArgumentOutOfRangeException("row", string.Format("Dimensions of the matrix should be in the range [{0}-{1}]", MinSize, MaxSize));
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                if (!this.ValidateDimensions(value))
                {
                    throw new ArgumentOutOfRangeException("col", string.Format("Dimensions of the matrix should be in the range [{0}-{1}]", MinSize, MaxSize));
                }

                this.cols = value;
            }
        }

        private bool ValidateDimensions(int dimension)
        {
            bool isValidDimension = (MinSize <= dimension) && (dimension <= MaxSize);

            return isValidDimension;
        }
    }
}
