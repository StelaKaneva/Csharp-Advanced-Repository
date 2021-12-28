using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
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
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                }

                commandInput = Console.ReadLine();
            }
        }
    }
}
