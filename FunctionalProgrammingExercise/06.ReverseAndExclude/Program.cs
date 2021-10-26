using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverse = x => 
            {
                List<int> newList = new List<int>();

                for (int i = x.Count - 1; i >= 0; i--)
                {
                    newList.Add(x[i]);
                }

                return newList;
            };

            List<int> newList = reverse(numbers);

            Func<int, bool> predicate = x => x % n != 0;

            newList = newList.Where(predicate).ToList();

            Action<List<int>> printAction = x => { Console.WriteLine(String.Join(" ", x)); };

            printAction(newList);
        }
    }
}
