using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //Func<List<string>, List<string>> checkLength = x =>
            //{
            //    List<string> newList = new List<string>();

            //    foreach (var item in x)
            //    {
            //        if (item.Length <= n)
            //        {
            //            newList.Add(item);
            //        }
            //    }

            //    return newList;
            //};

            //List<string> newList = checkLength(names);

            //Action<List<string>> printAction = x => { Console.WriteLine(String.Join(Environment.NewLine, x)); };

            //printAction(newList);

            Func<string, bool> predicate = x => x.Length <= n;

            names = names.Where(predicate).ToList();

            Action<List<string>> printAction = x => { Console.WriteLine(String.Join(Environment.NewLine, x)); };

            printAction(names);
        }
    }
}
