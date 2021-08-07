using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = data[0];
            int m = data[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int firstNumbers = int.Parse(Console.ReadLine());
                firstSet.Add(firstNumbers);
            }

            for (int i = 0; i < m; i++)
            {
                int secondNumbers = int.Parse(Console.ReadLine());
                secondSet.Add(secondNumbers);
            }

            var result = firstSet.Intersect(secondSet);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
