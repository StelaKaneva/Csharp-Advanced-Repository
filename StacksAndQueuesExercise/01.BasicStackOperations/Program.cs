using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElementsToPush = array[0];
            int numberOfElementsToPop = array[1];
            int numberToCheckFor = array[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToCheckFor))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
