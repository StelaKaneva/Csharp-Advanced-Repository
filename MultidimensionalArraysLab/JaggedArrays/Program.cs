using System;
using System.Linq;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++) //matrix.Length - vrushta goleminata na purviya, glavniya masiv (v nashiya sluchay tova e rows, procheteno ot  konzolata)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++) // goleminata veche e dinamichna - kolkoto sme vuveli, tolkova tryabva da prochetem
                {
                    matrix[row][col] = rowData[col];
                }
            }

            for (int row = 0; row < matrix.Length; row++)//kolkoto e goleminata na cyalata matrica
            {
                for (int col = 0; col < matrix[row].Length; col++)//goleminata na tekushtiya red
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
