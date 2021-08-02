using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            string[,] matrix = new string[rows, cols];
            int counter = 0;
            bool notFound = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                counter = 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData.Substring(counter, 1);
                    counter++;
                }
            }

            string symbol = Console.ReadLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        notFound = false;
                        return;
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
