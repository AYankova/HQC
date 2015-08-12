namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    internal class Engine
    {
        internal static void Start()
        {
            const int FieldsWithNoMines = 35;
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] mines = PlaceMines();
            int pointsCounter = 0;
            int row = 0;
            int col = 0;
            bool gameOver = false;
            bool inGame = true;
            bool gameWon = false;
            List<Points> highScores = new List<Points>(6);

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Lets play MineSweeper. Try to find all the fields with no mines placed. " +
                    "Command 'top' shows highscores, 'restart' starts a new game, 'exit' quits the game!");
                    PrintBoard(board);
                    inGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighScores(highScores);
                        break;
                    case "restart":
                        board = CreateBoard();
                        mines = PlaceMines();
                        PrintBoard(board);
                        gameOver = false;
                        inGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                PlayerTurn(board, mines, row, col);
                                pointsCounter++;
                            }

                            if (FieldsWithNoMines == pointsCounter)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError!Invalid command\n");
                        break;
                }

                if (gameOver)
                {
                    PrintBoard(mines);
                    Console.Write("Boom! You fought like a hero and got {0} points. " + "Enter your nickname: ", pointsCounter);
                    string nickname = Console.ReadLine();
                    Points result = new Points(nickname, pointsCounter);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].PlayerPoints < result.PlayerPoints)
                            {
                                highScores.Insert(i, result);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Points result1, Points result2) => result2.PlayerName.CompareTo(result1.PlayerName));
                    highScores.Sort((Points result1, Points result2) => result2.PlayerPoints.CompareTo(result1.PlayerPoints));
                    PrintHighScores(highScores);

                    board = CreateBoard();
                    mines = PlaceMines();
                    pointsCounter = 0;
                    gameOver = false;
                    inGame = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nCongratulations!You opened all the 35 fields with no mines!");
                    PrintBoard(mines);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Points points = new Points(name, pointsCounter);
                    highScores.Add(points);
                    PrintHighScores(highScores);
                    board = CreateBoard();
                    mines = PlaceMines();
                    pointsCounter = 0;
                    gameWon = false;
                    inGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria !");
            Console.Read();
        }

        private static void PrintHighScores(List<Points> points)
        {
            Console.WriteLine("\nPoints:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].PlayerName, points[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores available!\n");
            }
        }

        private static void PlayerTurn(char[,] board, char[,] mines, int row, int col)
        {
            char minesCount = CountMines(mines, row, col);
            mines[row, col] = minesCount;
            board[row, col] = minesCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardCols = 10;
            char[,] board = new char[boardRows, boardCols];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardCols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int randNumber = random.Next(50);

                if (!mines.Contains(randNumber))
                {
                    mines.Add(randNumber);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine / cols;
                int col = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void Calculations(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char minesCount = CountMines(board, i, j);
                        board[i, j] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] board, int row, int col)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < row) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}