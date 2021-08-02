using System;

namespace MatrixDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = new int[3, 2];
            //matrix[0, 0] = 55;
            //matrix[0, 1] = 45;
            //Console.WriteLine(matrix[0,0]);


            int[,] matrix =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine(matrix[1, 1]); // 5
            Console.WriteLine(matrix[2, 2]); // 9

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++) 
                {
                    Console.Write (matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
