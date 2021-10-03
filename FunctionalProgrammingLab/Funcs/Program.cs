using System;
using System.IO;

namespace Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> firstDelegate = SumNumbers;
            //Console.WriteLine(firstDelegate(5, 5)); //SumNumbers(5, 5);
            //firstDelegate = MultiplyNumbers;
            //Console.WriteLine(firstDelegate(5, 5));

            Func<int, int, int> sumDelegate = SumNumbers;
            Func<int, int, int> multiplyDelegate = MultiplyNumbers;
            //Func<int, string> toString = x => x.ToString();
            //Console.WriteLine(toString(5));

            Calculate(5, 5, sumDelegate);
            Calculate(5, 5, multiplyDelegate);
            Calculate(5, 5, (a, b) => a / b);
            Calculate(5, 5, (a, b) => a * 100 * b * 100);
        }

        static int SumNumbers(int a, int b)
        {
            Console.WriteLine("Summing is the best feeling");
            return a + b;
        }

        static int MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("Multiplying is the worst feeling");
            return a * b;
        }

        static void Calculate(int a, int b, Func<int, int, int> operation)
        {
            using (StreamWriter writer = new StreamWriter("../../../result.txt", true))
            {
                writer.WriteLine("Start calculating");
                writer.WriteLine(operation(a, b));
            }
        }
    }
}
