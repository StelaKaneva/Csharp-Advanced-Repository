using System;
using System.Linq;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());

            int happyKids = 0;

            int n = int.Parse(Console.ReadLine());

            string[,] neighborhood = new string[n, n];

            int santaRow = -1;
            int santaCol = -1;

            for (int row = 0; row < neighborhood.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < neighborhood.GetLength(1); col++)
                {
                    neighborhood[row, col] = rowData[col];

                    if (rowData[col] == "S")
                    {
                        santaRow = row;
                        santaCol = col;
                    }

                    if (rowData[col] == "V")
                    {
                        happyKids++;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "Christmas morning")
            {
                neighborhood[santaRow, santaCol] = "-";

                if (command == "up")
                {
                    santaRow--;
                }
                else if (command == "down")
                {
                    santaRow++;
                }
                else if (command == "left")
                {
                    santaCol--;
                }
                else if (command == "right")
                {
                    santaCol++;
                }

                if (neighborhood[santaRow, santaCol] == "X")
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (neighborhood[santaRow, santaCol] == "V")
                {
                    countOfPresents--;

                    if (countOfPresents == 0)
                    {
                        Console.WriteLine("Santa ran out of presents!");
                        break;
                    }
                }

                if (neighborhood[santaRow, santaCol] == "C")
                {
                    if (neighborhood[santaRow, santaCol + 1] != "-")
                    {
                        countOfPresents--;
                        neighborhood[santaRow, santaCol + 1] = "-";

                        if (countOfPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                    }

                    if (neighborhood[santaRow, santaCol - 1] != "-")
                    {
                        countOfPresents--;
                        neighborhood[santaRow, santaCol - 1] = "-";

                        if (countOfPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                    }

                    if (neighborhood[santaRow - 1, santaCol] != "-")
                    {
                        countOfPresents--;
                        neighborhood[santaRow - 1, santaCol] = "-";

                        if (countOfPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                    }

                    if (neighborhood[santaRow + 1, santaCol] != "-")
                    {
                        countOfPresents--;
                        neighborhood[santaRow + 1, santaCol] = "-";

                        if (countOfPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }

            int goodKidsLeft = 0;

            neighborhood[santaRow, santaCol] = "S";

            foreach (var item in neighborhood)
            {
                if (item == "V")
                {
                    goodKidsLeft++;
                }
            }

            for (int row = 0; row < neighborhood.GetLength(0); row++)
            {
                for (int col = 0; col < neighborhood.GetLength(1); col++)
                {
                    Console.Write(neighborhood[row, col] + " ");
                }

                Console.WriteLine();
            }

            if (goodKidsLeft == 0)
            {
                Console.WriteLine($"Good job, Santa! {happyKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {goodKidsLeft} nice kid/s.");
            }
        }
    }
}
