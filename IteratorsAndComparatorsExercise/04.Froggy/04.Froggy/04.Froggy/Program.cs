using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
