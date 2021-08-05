using System;
using System.Collections.Generic;

namespace SetsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int>();
            nums.Add(5);
            nums.Add(6);
            nums.Add(6);
            nums.Add(6);
            nums.Add(6);//shte se dobavi samo vednuj - setut se sustoi ot unikalni elementi
            nums.Add(7);
            nums.Add(1);

            nums.Remove(6);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(nums.Contains(6));//False
            Console.WriteLine(nums.Contains(66));//False
        }
    }
}
