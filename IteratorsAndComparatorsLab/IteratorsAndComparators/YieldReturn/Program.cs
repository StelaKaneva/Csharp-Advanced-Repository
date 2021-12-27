using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var name in GetNames())
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine("In the foreach");
            //}

            IEnumerator enumerator = GetNames().GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static IEnumerable<string> GetNames()
        {
            yield return "Gosho";
            Console.WriteLine("In the method");
            yield return "Pesho";
            Console.WriteLine("Sled Pesho sum");
            Console.WriteLine("In the method");
            yield return "Dimitrichko";
            Console.WriteLine("In the method");
        }
    }
}
