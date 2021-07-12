using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            
            Queue<int[]> pumps = new Queue<int[]>();
            FillQueue(n, pumps);

            while (true)
            {
                int fuelAmount = 0;
                bool foundPoint = true;

                for (int i = 0; i < n; i++)
                {
                    int[] current = pumps.Dequeue();
                    fuelAmount += current[0];

                    if (fuelAmount < current[1])
                    {
                        foundPoint = false;
                    }

                    fuelAmount -= current[1];
                    pumps.Enqueue(current);
                }

                if (foundPoint)
                {
                    break;
                }

                counter++;

                pumps.Enqueue(pumps.Dequeue()); //vadim purvata i q slagame nay-otzad
            }

            Console.WriteLine(counter);
        }

        private static void FillQueue(int n, Queue<int[]> pumps)
        {
            for (int i = 0; i < n; i++)
            {
                int[] currentPump = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                pumps.Enqueue(currentPump);
            }
        }
    }
}
