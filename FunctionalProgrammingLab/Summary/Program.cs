using System;

namespace Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateNumbers(5, 5, Sum);
            CalculateNumbers(5, 5, Divide);
            CalculateNumbers(5, 5, Multiply);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static void CalculateNumbers(int a, int b, Func<int, int, int> operation)
        {
            Console.WriteLine($"Calculating {a} and {b}");
            int result = operation(a, b);
            Console.WriteLine($"The result  is: {result}");
        }
    }
}
