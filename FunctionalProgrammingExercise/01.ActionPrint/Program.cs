using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Action<string[]> print = a => Console.WriteLine(String.Join(Environment.NewLine, a));
            print(input);
        }
    }
}
