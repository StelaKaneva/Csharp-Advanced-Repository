using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n && cars.Any(); i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }

                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    cars.Enqueue(input);
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
