using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select                         (int.Parse).ToArray();

            //Array.Sort(numbers, (x, y) => x.CompareTo(y));


            //Array.Sort(numbers, (x, y) => 
            //{
            //    int compare = 0;

            //    if (x < y)
            //    {
            //        compare = -1;
            //    }
            //    else if (x > y)
            //    {
            //        compare = 1;
            //    }

            //    return compare;
            //});


            //Array.Sort(numbers, (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 : (x % 2 != 0 && y % 2 == 0) ? 1 : x.CompareTo(y));


            Array.Sort(numbers, (x, y) =>
            {
                int sorter = 0;

                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    sorter = 1;
                }
                else
                {
                    sorter = x - y;
                }

                return sorter;
            });

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
