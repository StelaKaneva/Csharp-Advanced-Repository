using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, bool> upperChecker = n => n[0] == n.ToUpper()[0];
            //string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(upperChecker).ToArray();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s[0] == s.ToUpper()[0]).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, input));
        }
    }
}
