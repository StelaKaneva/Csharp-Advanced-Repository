using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int valueClaimedItems = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int sum = 0;
                int currentFirstItem = firstBox.Peek();
                int currentSecondItem = secondBox.Peek();
                sum = currentFirstItem + currentSecondItem;

                if (sum % 2 == 0)
                {
                    valueClaimedItems += sum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0 && secondBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
                Console.WriteLine("Second lootbox is empty");
            }
            else if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (valueClaimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {valueClaimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {valueClaimedItems}");
            }
        }
    }
}
