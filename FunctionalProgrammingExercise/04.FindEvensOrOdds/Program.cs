using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myIntParse = s => int.Parse(s);

            int[] ranges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(myIntParse)
                            .ToArray();

            int start = ranges[0];
            int end = ranges[1];

            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateList(start, end);

            if (criteria == "even")
            {
                //Predicate<int> evenPredicate = n => n % 2 == 0;
                Func<int, bool> evenPredicate = n => n % 2 == 0;
                numbers = numbers.Where(evenPredicate).ToList();
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Func<int, bool> oddPredicate = n => n % 2 != 0;
                numbers = numbers.Where(oddPredicate).ToList();
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
