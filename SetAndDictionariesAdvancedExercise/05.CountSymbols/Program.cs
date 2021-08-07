using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurences.ContainsKey(input[i]))
                {
                    occurences.Add(input[i], 0);
                }

                occurences[input[i]]++;
            }

            foreach (var symbol in occurences)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
