using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            List<int> result = new List<int>();

            //var result = queue.Where(n => n % 2 == 0).ToList();

            //Console.WriteLine(String.Join(", ", result));

            while (queue.Any())
            {
                var number = queue.Dequeue();

                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
