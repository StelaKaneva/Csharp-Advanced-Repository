using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFlowerWreaths = 0;
            int countFlowersLeft = 0;

            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int sum = 0;
                int currentLily = lilies.Peek();
                int currentRose = roses.Peek();
                sum = currentLily + currentRose;

                if (sum == 15)
                {
                    countFlowerWreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    int lilyToBeDecreased = lilies.Pop() - 2;
                    lilies.Push(lilyToBeDecreased);
                }
                else
                {
                    countFlowersLeft += lilies.Pop() + roses.Dequeue();
                }
            }

            if (countFlowersLeft > 0)
            {
                countFlowerWreaths += countFlowersLeft / 15;
            }

            if (countFlowerWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {countFlowerWreaths} wreaths!");
            }
            else
            {
                int countNeededWreaths = 5 - countFlowerWreaths;
                Console.WriteLine($"You didn't make it, you need {countNeededWreaths} wreaths more!");
            }
        }
    }
}
