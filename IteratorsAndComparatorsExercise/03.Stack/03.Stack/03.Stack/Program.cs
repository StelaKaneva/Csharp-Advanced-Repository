using System;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] tokens = commandInput.Split(new string[]{" ", ", "}, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Push")
                {
                    foreach (var item in tokens.Skip(1))
                    {
                        myStack.Push(int.Parse(item));
                    }
                }
                else if (command == "Pop")
                {
                    if (myStack.Count == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        myStack.Pop();
                    }
                }
                
                commandInput = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
