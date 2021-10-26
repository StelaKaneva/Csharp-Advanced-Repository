using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            //input = input.Select(name => $"Sir {name}").ToList();
            input = MySelect(input, n => $"Sir {n}");
            Action<List<string>> print = a => Console.WriteLine(String.Join(Environment.NewLine, a));
            print(input);
        }

        static List<string> MySelect(List<string> items, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in items)
            {
                string newItem = func(item);
                newList.Add(newItem);
            }

            return newList;
        }
    }
}
