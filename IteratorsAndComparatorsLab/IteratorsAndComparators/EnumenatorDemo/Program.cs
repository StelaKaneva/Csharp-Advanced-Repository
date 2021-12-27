using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ");

            //StringEnumerator enumerator = new StringEnumerator(array);
            //IEnumerator enumerator = array.GetEnumerator();

            List<int> numbers = new List<int>() { 1, 2, 3 };
            IEnumerator enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach (var number in numbers)// идентични са двете неща
            {
                Console.WriteLine(number);
            }
        }
    }
}
