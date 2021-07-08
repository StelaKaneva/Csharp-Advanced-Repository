using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    int totalElementsToRemove = int.Parse(command[1]);

                    for (int i = 0; i < totalElementsToRemove; i++)
                    {
                        if (stack.Any() && stack.Count >= totalElementsToRemove)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
