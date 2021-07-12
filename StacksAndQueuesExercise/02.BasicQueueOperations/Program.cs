using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfElementsToEnqueue = array[0];
            int numberOfElementsToDequeue = array[1];
            int numberToCheckFor = array[2];

            Queue<int> queue = new Queue<int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numberOfElementsToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numberOfElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(numberToCheckFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
