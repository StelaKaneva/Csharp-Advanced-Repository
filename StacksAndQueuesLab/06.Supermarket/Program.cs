using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }

                    input = Console.ReadLine();
                    continue;
                }

                customers.Enqueue(input);

                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
