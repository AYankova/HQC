namespace RotatingWalkInMatrix
{
    using System;

    public class Position
    {
        private const int MinValue = -1;
        private const int MaxValue = 1;
        private int row;
        private int col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                this.col = value;
            }
        }
    }
}
