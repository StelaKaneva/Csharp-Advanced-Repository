using System;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                                .ToArray();
            int n = input[0];
            int m = input[1];

            int[,] matrix = new int[n, m];

            string command = Console.ReadLine();
            int rowIndex = 0;
            int colIndex = 0;
            int countOfFlowers = 0;

            while (command != "Bloom Bloom Plow")
            {
                int[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                                .ToArray();
                rowIndex = tokens[0];
                colIndex = tokens[1];

                if (!isSafe(matrix, rowIndex, colIndex))
                {
                    command = Console.ReadLine();
                    continue;
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[rowIndex, colIndex] = -1;
                        countOfFlowers++;
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == -1)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (matrix[row, i] != -1)
                            {
                                matrix[row, i] += 1;
                            }
                            else
                            {
                                matrix[row, i] += 3;
                            }

                        }

                        for (int j = 0; j < m; j++)
                        {
                            if (matrix[j, col] != -1)
                            {
                                matrix[j, col] += 1;
                            }
                            else
                            {
                                matrix[j, col] += 3;
                            }
                        }

                        matrix[row, col] = 1;
                    }

                    
                    }
                }
            }

            Print(matrix);

        }

        static bool isSafe(int[,] matrix, int row, int col)
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

        static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
