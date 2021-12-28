using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                try
                {
                    string[] tokens = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string command = tokens[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> elements = tokens.Skip(1).ToList();
                            listyIterator = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "PrintAll":
                            foreach (var item in listyIterator)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                commandInput = Console.ReadLine();
                
            }
        }
    }
}
