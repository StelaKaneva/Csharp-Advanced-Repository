using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var splitted = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);
                bool isInvalid = false;

                if (matrix.Length <= row || row < 0)
                {
                    isInvalid = true;
                }
                else if (matrix[row].Length <= col || col < 0)
                {
                    isInvalid = true;
                }

                if (isInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (splitted[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (splitted[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                
                command = Console.ReadLine();
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
