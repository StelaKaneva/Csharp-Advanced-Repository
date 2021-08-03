using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            char[,] chessBoard = ReadMatrix(rows, cols);

            int countReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countAttacks = 0;

                        if (currentSymbol == 'K')
                        {
                            // Tryabva da izchislim broya na atakite mu.

                            countAttacks = GetAttacks(chessBoard, row, col, countAttacks);

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }

                        }
                    }
                }

                //maxAttacks

                if (maxAttacks > 0)
                {
                    chessBoard[rowKiller, colKiller] = '0';
                    countReplaced++;
                }
                else // maxAttacks = 0
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
                
            }
        }

        private static int GetAttacks(char[,] chessBoard, int row, int col, int countAttacks)
        {
            if (isInside(chessBoard, row - 2, col + 1))
            {
                if (chessBoard[row - 2, col + 1] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row - 2, col - 1))
            {
                if (chessBoard[row - 2, col - 1] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row - 1, col - 2))
            {
                if (chessBoard[row - 1, col - 2] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row - 1, col + 2))
            {
                if (chessBoard[row - 1, col + 2] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row + 1, col - 2))
            {
                if (chessBoard[row + 1, col - 2] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row + 1, col + 2))
            {
                if (chessBoard[row + 1, col + 2] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row + 2, col - 1))
            {
                if (chessBoard[row + 2, col - 1] == 'K')
                {
                    countAttacks++;
                }
            }

            if (isInside(chessBoard, row + 2, col + 1))
            {
                if (chessBoard[row + 2, col + 1] == 'K')
                {
                    countAttacks++;
                }
            }

            return countAttacks;
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
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

        private static bool isInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0) && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
            
        }
    }
}
