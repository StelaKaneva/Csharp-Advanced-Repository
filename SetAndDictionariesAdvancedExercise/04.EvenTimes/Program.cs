using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> occurences = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!occurences.ContainsKey(currentNum))
                {
                    occurences.Add(currentNum, 0);
                }

                occurences[currentNum]++;
            }

            foreach (var number in occurences)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }

            // var num = occurences.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
        }
    }
}
