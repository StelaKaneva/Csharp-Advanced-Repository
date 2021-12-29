using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> males = new Stack<int>(firstInput);
            Queue<int> females = new Queue<int>(secondInput);

            int matchesCount = 0;

            while (males.Count != 0 && females.Count != 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();


                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }


                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }

                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }

                if (currentMale == currentFemale)
                {
                    matchesCount++;
                    females.Dequeue();
                    males.Pop();
                }
                else
                {
                    int maleToBePushed = males.Pop() - 2;
                    males.Push(maleToBePushed);
                    females.Dequeue();
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            if (males.Count == 0 && females.Count == 0)
            {
                Console.WriteLine("Males left: none");
                Console.WriteLine("Females left: none");
                return;
            }
            
            if (males.Count <= 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {String.Join(", ", males)}");
            }

            if (females.Count <= 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {String.Join(", ", females)}");
            }
        }
    }
}
