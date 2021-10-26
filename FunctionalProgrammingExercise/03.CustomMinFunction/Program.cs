using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myIntParse = s => int.Parse(s);

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(myIntParse)
                            //.Select(int.Parse)
                            //.Select(x => int.Parse(x))
                            .ToArray();

            Func<int[], int> minFunc = nums =>
            {
                int minNum = int.MaxValue;

                foreach (var num in nums)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }

                return minNum;
            };

            Console.WriteLine(minFunc(numbers));
        }

        static int GetMin(int[] nums)
        {
            int minNum = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            return minNum;
        }
    }
}
