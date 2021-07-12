using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(array);

            int sum = 0;
            int counter = 1;

            while (stack.Any())
            {
                int currentClothes = stack.Pop();

                sum += currentClothes;

                if (sum < capacity)
                {
                    continue;
                }
                else if (sum == capacity)
                {
                    if (stack.Any())
                    {
                        counter++;
                    }

                    sum = 0;
                }
                else if (sum > capacity)
                {
                    counter++;
                    stack.Push(currentClothes);
                    sum = 0;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
