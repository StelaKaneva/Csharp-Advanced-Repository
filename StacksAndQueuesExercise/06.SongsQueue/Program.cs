using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(songs);

            while (true)
            {
                
                if (queue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4, command.Length - 4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ", queue));
                }

            }
        }
    }
}
