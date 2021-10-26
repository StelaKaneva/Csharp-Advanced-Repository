using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //Func<string, int> getASCIISum = p =>
            //{
            //    int result = 0;

            //    for (int i = 0; i < p.Length; i++)
            //    {
            //        result += p[i];
            //    }

            //    return result;
            //};

            Func<string, int> getASCIISum = p => p.Select(c => (int)c).Sum();

            //string person = GetName(people, n, getASCIISum);
            //Console.WriteLine(person);

            Func<List<string>, int, Func<string, int>, string> funcResult = (people, n, func) =>
            {
                return people.FirstOrDefault(p => func(p) >= n);
            };

            string result = funcResult(people, n, getASCIISum);
            Console.WriteLine(result);
        }

        static string GetName(List<string> people, int n, Func<string, int> func)
        {
            string result = null;
            
            foreach (string person in people)
            {
                if (func(person) >= n)
                {
                    result = person;
                    break;
                }
            }
            return result;
        }
    }
}
