using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFoodForTheDay = int.Parse(Console.ReadLine());
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQuantity = new Queue<int>(data);

            if (ordersQuantity.Any())
            {
                Console.WriteLine(ordersQuantity.Max());
            }
            
            bool allOrdersAreComplete = true;

            for (int i = 0; i < data.Length; i++)
            {
                int eachOrderQuantity = data[i];

                if (quantityOfFoodForTheDay - eachOrderQuantity >= 0)
                {
                    quantityOfFoodForTheDay -= ordersQuantity.Dequeue();
                }
                else if (quantityOfFoodForTheDay - eachOrderQuantity < 0)
                {
                    List<int> result = new List<int>(ordersQuantity);
                    Console.Write("Orders left: ");
                    Console.WriteLine(String.Join(" ", result));
                    allOrdersAreComplete = false;
                    break;
                }

            }

            if (allOrdersAreComplete)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
