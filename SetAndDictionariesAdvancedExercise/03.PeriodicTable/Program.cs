using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                for (int j = 0; j < data.Length; j++)
                {
                    periodicTable.Add(data[j]);
                }
            }

            var sorted = periodicTable.OrderBy(x => x);
            Console.WriteLine(String.Join(" ", sorted));
        }
    }
}
