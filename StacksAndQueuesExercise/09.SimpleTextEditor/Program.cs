using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "1")
                {
                    string someText = command[1];
                    stack.Push(sb.ToString());
                    sb.Append(someText);
                    
                }
                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);
                    stack.Push(sb.ToString());
                    sb.Remove(sb.Length - count, count);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else if (command[0] == "4")
                {
                    var beforeOperation = stack.Pop();
                    sb.Clear();
                    sb.Append(beforeOperation);
                }
            }
        }
    }
}
