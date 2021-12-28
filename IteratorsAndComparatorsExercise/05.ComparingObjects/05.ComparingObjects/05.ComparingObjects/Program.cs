using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] tokens = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person person1 = new Person(name, age, town);

                people.Add(person1);

                commandInput = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            Person person = people[n - 1];

            int numbeOfNotEqualPeople = 0;
            int countOfMatches = 0;

            foreach (Person currentPerson in people)
            {
                int result = person.CompareTo(currentPerson);

                if (result < 0)
                {
                    numbeOfNotEqualPeople++;
                }
                else if (result > 0)
                {
                    numbeOfNotEqualPeople++;
                }
                else if (result == 0)
                {
                    countOfMatches++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {numbeOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
