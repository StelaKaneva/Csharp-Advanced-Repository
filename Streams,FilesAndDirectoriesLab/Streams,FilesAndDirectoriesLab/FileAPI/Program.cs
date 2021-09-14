using System;
using System.IO;

namespace FileAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("../../../output.txt", "Files are fun");
            Console.WriteLine(File.ReadAllText("../../../output.txt"));
        }
    }
}
