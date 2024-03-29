﻿using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string line = reader.ReadLine();
                int index = 0;

                while (line != null)
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    index++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
