﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string inputCommand = Console.ReadLine();
            List<string> filters = new List<string>();

            while (inputCommand != "Print")
            {
                string[] tokens = inputCommand.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandName = tokens[0];
                string filterType = tokens[1];
                string argument = tokens[2];

                if (commandName == "Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName == "Remove filter")
                {
                    filters.Remove($"{filterType};{argument}"); ;
                }
                
                inputCommand = Console.ReadLine();
            }

            foreach (string filterline in filters)
            {
                string[] tokens = filterline.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string filterType = tokens[0];
                string argument = tokens[1];

                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", people));
        }
    }
}
