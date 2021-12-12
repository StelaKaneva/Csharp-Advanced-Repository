using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> values = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double currentValue = double.Parse(Console.ReadLine());
                values.Add(currentValue);
            }

            double elementToCompare = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(values);
            Console.WriteLine(box.CountOfGreaterValues(elementToCompare, values));
        }
    }
}
