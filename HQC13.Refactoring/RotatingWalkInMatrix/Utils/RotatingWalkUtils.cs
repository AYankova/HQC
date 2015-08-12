namespace RotatingWalkInMatrix
{
    using System;

    public static class RotatingWalkUtils
    {
        internal static readonly int[] ChangeByRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
        internal static readonly int[] ChangeByColumn = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private const int DirectionCount = 8;

        public static Position FindFirstEmptyCell(this int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        return new Position(row, col);
                    }
                }
            }

            return null;
        }

        public static bool CanGoToPosition(this int[,] matrix, Position position)
        {
            bool isRowInRange = 0 <= position.Row && position.Row < matrix.GetLength(0);
            bool isColInRange = 0 <= position.Col && position.Col < matrix.GetLength(1);

            return isRowInRange && isColInRange && matrix[position.Row, position.Col] == 0;
        }

        public static Direction FindNewPosition(this int[,] matrix, Direction direction, Position position)
        {
            for (int i = 0; i < DirectionCount; i++)
            {
                Direction currDirection = (Direction)(((int)direction + i) % DirectionCount);
                int currRow = position.Row + ChangeByRow[(int)currDirection];
                int currCol = position.Col + ChangeByColumn[(int)currDirection];
                Position newPosition = new Position(currRow, currCol);

                if (CanGoToPosition(matrix, newPosition))
                {
                    return currDirection;
                }
            }

            throw new InvalidOperationException("Matrix is already filled.");
        }

        public static bool AreNeighbourCellsFilled(this int[,] matrix, Position position)
        {
            int upRow;
            int downRow;
            int leftCol;
            int rightCol;

            if (position.Row > 0)
            {
                upRow = position.Row - 1;
            }
            else
            {
                upRow = position.Row;
            }

            if (position.Row < matrix.GetLength(0) - 1)
            {
                downRow = position.Row + 1;
            }
            else
            {
                downRow = position.Row;
            }

            if (position.Col < matrix.GetLength(1) - 1)
            {
                rightCol = position.Col + 1;
            }
            else
            {
                rightCol = position.Col;
            }

            if (position.Col > 0)
            {
                leftCol = position.Col - 1;
            }
            else
            {
                leftCol = position.Col;
            }

            for (int i = upRow; i <= downRow; i++)
            {
                for (int j = leftCol; j <= rightCol; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
