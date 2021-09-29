using System;
using System.IO;

namespace Flush
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            using (var writer = new StreamWriter("../../../output.txt"))
            {
                while (command != "End")
                {
                    if (command == "flush")
                    {
                        writer.Flush();
                    }
                    else
                    {
                        writer.WriteLine(command);
                    }
                    
                    command = Console.ReadLine();
                }
            }
        }
    }
}
