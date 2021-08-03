using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = ReadMatrix(rows, cols);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data[0] == "swap" && data.Length == 5)
                {
                    int rowIndexFirst = int.Parse(data[1]);
                    int colIndexFirst = int.Parse(data[2]);
                    int rowIndexSecond = int.Parse(data[3]);
                    int colIndexSecond = int.Parse(data[4]);

                    if (rowIndexFirst <= matrix.GetLength(0) && rowIndexSecond <= matrix.GetLength(0) && colIndexFirst <= matrix.GetLength(1) && colIndexSecond <= matrix.GetLength(1))
                    {
                        string firstElement = matrix[rowIndexFirst, colIndexFirst];
                        string secondElement = matrix[rowIndexSecond, colIndexSecond];

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (row == rowIndexFirst && col == colIndexFirst)
                                {
                                    matrix[row, col] = secondElement;
                                }

                                if (row == rowIndexSecond && col == colIndexSecond)
                                {
                                    matrix[row, col] = firstElement;
                                }
                            }
                        }

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                
                command = Console.ReadLine();
            }
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
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
