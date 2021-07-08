using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var toss = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);

            int currrentIndex = 1;

            while (queue.Count > 1)
            {
                var currentName = queue.Dequeue();

                if (currrentIndex == toss)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currrentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);
                }

                currrentIndex++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
