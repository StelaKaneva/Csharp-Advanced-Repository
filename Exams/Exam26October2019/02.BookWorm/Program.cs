using System;
using System.Text;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialString = Console.ReadLine();
            StringBuilder result = new StringBuilder(initialString);
            
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            matrix[playerRow, playerCol] = '-';

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    playerRow--;

                    if (!isSafe(matrix, playerRow, playerCol))
                    {
                        playerRow++;
                        
                        if (result.Length != 0)
                        {
                            result.Remove(result.Length - 1, 1);
                        }
                    }
                }
                else if (command == "down")
                {
                    playerRow++;

                    if (!isSafe(matrix, playerRow, playerCol))
                    {
                        playerRow--;

                        if (result.Length != 0)
                        {
                            result.Remove(result.Length - 1, 1);
                        }
                    }
                }
                else if (command == "left")
                {
                    playerCol--;

                    if (!isSafe(matrix, playerRow, playerCol))
                    {
                        playerCol++;

                        if (result.Length != 0)
                        {
                            result.Remove(result.Length - 1, 1);
                        }
                    }
                }
                else if (command == "right")
                {
                    playerCol++;

                    if (!isSafe(matrix, playerRow, playerCol))
                    {
                        playerCol--;

                        if (result.Length != 0)
                        {
                            result.Remove(result.Length - 1, 1);
                        }
                    }
                }

                if (matrix[playerRow, playerCol] != '-')
                {
                    result.Append(matrix[playerRow, playerCol]);
                }

                matrix[playerRow, playerCol] = '-';
                command = Console.ReadLine();
            }

            Console.WriteLine(result.ToString().TrimEnd());
            matrix[playerRow, playerCol] = 'P';
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        static bool isSafe(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }

            if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
