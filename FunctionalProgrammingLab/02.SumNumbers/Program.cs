using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();

            //PrintResults(numbers, GetCount, Sum);

            PrintResults(numbers, GetCount, x =>
            {
                return x.Sum(); //може и с for цикъл
            });
        }

        static int GetCount(int[] numbers)
        {
            return numbers.Length;
        }

        static int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        static void PrintResults(int[] numbers, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(numbers));
            Console.WriteLine(sum(numbers));
        }

        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }
    }
}
