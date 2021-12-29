using System;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = -1;
            int playerCol = -1;
            bool reachedFinish = false;

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            matrix[playerRow, playerCol] = '-';

            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();

                if (command == "down")
                {
                    playerRow++;

                    if (playerRow >= matrix.GetLength(0))
                    {
                        playerRow = 0;
                    }
                }
                else if (command == "up")
                {
                    playerRow--;

                    if (playerRow < 0)
                    {
                        playerRow = n - 1;
                    }
                }
                else if (command == "right")
                {
                    playerCol++;

                    if (playerCol >= n)
                    {
                        playerCol = 0;
                    }
                }
                else if (command == "left")
                {
                    playerCol--;

                    if (playerCol < 0)
                    {
                        playerCol = n - 1;
                    }
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    if (command == "down")
                    {
                        playerRow++;

                        if (playerRow >= matrix.GetLength(0))
                        {
                            playerRow = 0;
                        }
                    }
                    else if (command == "up")
                    {
                        playerRow--;

                        if (playerRow < 0)
                        {
                            playerRow = n - 1;
                        }
                    }
                    else if (command == "right")
                    {
                        playerCol++;

                        if (playerCol >= n)
                        {
                            playerCol = 0;
                        }
                    }
                    else if (command == "left")
                    {
                        playerCol--;

                        if (playerCol < 0)
                        {
                            playerCol = n - 1;
                        }
                    }
                }

                if (matrix[playerRow, playerCol] == 'T')
                {
                    if (command == "down")
                    {
                        playerRow--;

                        if (playerRow < 0)
                        {
                            playerRow = n - 1;
                        }

                    }
                    else if (command == "up")
                    {
                        playerRow++;

                        if (playerRow >= matrix.GetLength(0))
                        {
                            playerRow = 0;
                        }
                    }
                    else if (command == "right")
                    {
                        playerCol--;

                        if (playerCol < 0)
                        {
                            playerCol = n - 1;
                        }

                    }
                    else if (command == "left")
                    {
                        playerCol++;

                        if (playerCol >= n)
                        {
                            playerCol = 0;
                        }
                    }

                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    reachedFinish = true;
                    break;
                }

                matrix[playerRow, playerCol] = '-';
            }

            if (reachedFinish)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            matrix[playerRow, playerCol] = 'f';
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,]matrix)
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
    }
}
