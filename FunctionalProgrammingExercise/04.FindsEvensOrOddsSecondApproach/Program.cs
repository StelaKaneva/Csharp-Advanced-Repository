using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindsEvensOrOddsSecondApproach
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
                Predicate<int> evenPredicate = n => n % 2 == 0;
                //Predicate<int> predicate = n => n % 2 == 0;
                //numbers = MyWhere(numbers, predicate);
                numbers = MyWhere(numbers, evenPredicate);
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Predicate<int> oddPredicate = n => n % 2 != 0;
                //predicate = n => n % 2 != 0;
                //numbers = MyWhere(numbers, predicate);
                numbers = MyWhere(numbers, oddPredicate);
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
