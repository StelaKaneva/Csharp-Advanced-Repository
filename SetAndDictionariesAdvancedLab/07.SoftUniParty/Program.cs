using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> vipGuests = new List<string>();
            List<string> regularGuests = new List<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (Char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
                
                input = Console.ReadLine();
            }

            string actualGuest = Console.ReadLine();

            while (actualGuest != "END")
            {
                if (Char.IsDigit(actualGuest[0]))
                {
                    if (vipGuests.Contains(actualGuest))
                    {
                        vipGuests.Remove(actualGuest);
                    }
                }
                else
                {
                    if (regularGuests.Contains(actualGuest))
                    {
                        regularGuests.Remove(actualGuest);
                    }
                }
                
                actualGuest = Console.ReadLine();
            }

            int count = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(count);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
