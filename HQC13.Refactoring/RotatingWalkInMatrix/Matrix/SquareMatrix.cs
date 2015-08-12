namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class SquareMatrix : Matrix
    {
        private int[,] matrix;

        public SquareMatrix(int size)
            : base(size)
        {
            this.matrix = new int[this.Rows, this.Cols];
        }

        public void FillMatrix()
        {
            Position position = this.matrix.FindFirstEmptyCell();
            Direction direction = Direction.DownRight;
            int rowMove = RotatingWalkUtils.ChangeByRow[(int)direction];
            int colMove = RotatingWalkUtils.ChangeByColumn[(int)direction];
            int cellValue = 1;

            while (cellValue <= this.Rows * this.Cols)
            {
                this.matrix[position.Row, position.Col] = cellValue;
                Position nextPosition = new Position(position.Row + rowMove, position.Col + colMove);

                if (!this.matrix.CanGoToPosition(nextPosition))
                {
                    bool areNeighbourCellsFilled = false;

                    if (this.matrix.AreNeighbourCellsFilled(position))
                    {
                        areNeighbourCellsFilled = true;

                        position = this.matrix.FindFirstEmptyCell();
                        if (position == null)
                        {
                            break;
                        }

                        direction = Direction.DownRight;
                    }
                    else
                    {
                        Position newPosition = new Position(position.Row, position.Col);
                        direction = this.matrix.FindNewPosition(direction, newPosition);
                    }

                    rowMove = RotatingWalkUtils.ChangeByRow[(int)direction];
                    colMove = RotatingWalkUtils.ChangeByColumn[(int)direction];

                    if (areNeighbourCellsFilled)
                    {
                        cellValue += 1;
                        continue;
                    }
                }

                position.Row += rowMove;
                position.Col += colMove;
                cellValue += 1;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0, 5}", this.matrix[row, col]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
