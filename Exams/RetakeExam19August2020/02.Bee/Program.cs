using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] beeTeritory = new char[n, n];

            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < beeTeritory.GetLength(0); row++)
            {
                var rowData = Console.ReadLine();

                for (int col = 0; col < beeTeritory.GetLength(1); col++)
                {
                    beeTeritory[row, col] = rowData[col];

                    if (rowData[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            int pollinatedFlowers = 0;

            while (command != "End")
            {
                beeTeritory[beeRow, beeCol] = '.';
                
                if (command == "up")
                {
                    beeRow--;
                }
                else if (command == "down")
                {
                    beeRow++;
                }
                else if (command == "left")
                {
                    beeCol--;
                }
                else if (command == "right")
                {
                    beeCol++;
                }

                if (beeRow < 0 || beeRow > n -1 || beeCol < 0 || beeCol > n - 1)
                {
                    Console.WriteLine($"The bee got lost!");

                    if (pollinatedFlowers < 5)
                    {
                        Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");

                        for (int row = 0; row < beeTeritory.GetLength(0); row++)
                        {
                            for (int col = 0; col < beeTeritory.GetLength(1); col++)
                            {
                                Console.Write(beeTeritory[row, col]);
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");

                        for (int row = 0; row < beeTeritory.GetLength(0); row++)
                        {
                            for (int col = 0; col < beeTeritory.GetLength(1); col++)
                            {
                                Console.Write(beeTeritory[row, col]);
                            }

                            Console.WriteLine();
                        }
                    }

                    return;
                }

                if (beeTeritory[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;

                }

                if (beeTeritory[beeRow, beeCol] == 'O')
                {
                    continue;
                }

                command = Console.ReadLine();
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            beeTeritory[beeRow, beeCol] = 'B';

            for (int row = 0; row < beeTeritory.GetLength(0); row++)
            {
                for (int col = 0; col < beeTeritory.GetLength(1); col++)
                {
                    Console.Write(beeTeritory[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
