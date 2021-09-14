using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    var line = reader.ReadLine();
                    int index = 0;

                    while (line != null)
                    {
                        writer.WriteLine($"{index}. {line}");
                        Console.WriteLine($"{index}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
