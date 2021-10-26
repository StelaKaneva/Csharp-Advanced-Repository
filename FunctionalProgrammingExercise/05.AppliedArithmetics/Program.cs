using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x * 2;
            Func<int, int> subtractFunc = x => x - 1;
            Action<List<int>> printAction = x => { Console.WriteLine(String.Join(" ", x)); };

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(addFunc).ToList();
                        //numbers = numbers.Select(x => addFunc(x)).ToList();
                        //numbers = numbers.Select(x => x + 1).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiplyFunc).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractFunc).ToList();
                        break;
                    case "print":
                        printAction(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
