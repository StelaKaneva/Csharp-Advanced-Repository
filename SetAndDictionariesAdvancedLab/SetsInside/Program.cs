using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SetsInside
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringHashSet set = new StringHashSet(8);

            //set.Add("hey");
            //set.Add("6");
            //set.Add("7");
            //set.Add("fsd");
            //set.Add("oshte");
            //set.Add("g");
            //set.Add("33");
            //set.Add("opa");

            //Console.WriteLine(set.Contains("33"));
            //Console.WriteLine(set.Contains("opa"));
            //Console.WriteLine(set.Contains("ff"));
            //Console.WriteLine(set.Contains("heyy"));

            int count = 1000000;
            int containsCount = 10000;
            List<string> list = new List<string>(count);
            HashSet<string> hash = new HashSet<string>(count);
            StringHashSet ourHash = new StringHashSet(count);

            for (int i = 0; i < count; i++)
            {
                list.Add(i.ToString());
                hash.Add(i.ToString());
                ourHash.Add(i.ToString());
            }

            Console.WriteLine("Start!");
            var timer = Stopwatch.StartNew();

            for (int i = 0; i < containsCount; i++)
            {
                bool exists = list.Contains(i.ToString());
            }

            timer.Stop();
            Console.WriteLine("List sux");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();

            for (int i = 0; i < containsCount; i++)
            {
                bool exists = hash.Contains(i.ToString());
            }

            timer.Stop();
            Console.WriteLine("C# one is ok");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();

            for (int i = 0; i < containsCount; i++)
            {
                bool exists = ourHash.Contains(i.ToString());
            }

            timer.Stop();
            Console.WriteLine("our is best!");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
        }

        static string GenerateString(int length = 8)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(rand.Next(0, 9));
            }

            return sb.ToString();
        }
    }
}
