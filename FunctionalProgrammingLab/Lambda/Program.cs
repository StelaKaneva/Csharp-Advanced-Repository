using System;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            numbers = numbers.Where((x, index) =>
            {
                Console.WriteLine($"Index is: {index}. Number is: {numbers[index]}");
                Console.WriteLine($"X: {x} -> {x % 2 == 0}");
                return x % 2 == 0;
            }).ToArray();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (CheckEven(numbers[i]))
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //numbers = numbers.Where(numbers => numbers % 2 == 0).ToArray();
            //numbers = numbers.Where(CheckEven).ToArray(); - Where може направо да приеме функцията. Това се нарича делегат.
            Console.WriteLine(String.Join(" ", numbers));
        }

        static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
