using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray());
            int taskToKill = int.Parse(Console.ReadLine());
            int currentTask = 0;
            int currentThread = 0;

            while (true)
            {
                currentTask = tasks.Peek();
                currentThread = threads.Peek();

                if (currentTask == taskToKill)
                {
                    break;
                }

                if (currentThread >= currentTask)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {currentThread} killed task {taskToKill}");
            Console.WriteLine(String.Join(" ", threads));
        }
    }
}
