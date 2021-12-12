using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> values = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentValue = Console.ReadLine();
                values.Add(currentValue);
            }

            string elementToCompare = Console.ReadLine();
            Box<string> box = new Box<string>(values);
            Console.WriteLine(box.CountOfGreaterValues(elementToCompare, values));
        }
    }
}
