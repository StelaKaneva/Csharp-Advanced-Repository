using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                people[i] = new Person()
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };
            }

            string condition = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = GetCondition(condition, ageToFilter);
            Action<Person> printerDelegate = GetPrinter(format);

            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }

            //Console.WriteLine("-----------");
            //FilterPeople(people, conditionDelegate, printerDelegate);
            //Console.WriteLine("--------");
            //FilterPeople(people, p => p.Name.Length <= 3, printerDelegate);
            //Console.WriteLine("----------------");
            //FilterPeople(people, p => true, p => Console.WriteLine($"{p.Name}"));
            //Console.WriteLine("----------------");
            //FilterPeople(people, FilterOldPeople, printerDelegate);
        }

        //static bool FilterOldPeople(Person person)
        //{
        //    return person.Age > 30;
        //}
        //static void FilterPeople(Person[] people, Func<Person, bool> filter, Action<Person> printer)
        //{
        //    foreach (var person in people)
        //    {
        //        if (filter(person))
        //        {
        //            printer(person);
        //        }
        //    }
        //}

        static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age": return p => { Console.WriteLine($"{p.Age}"); };
                case "name age": return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default: return null;
            }
        }
        static Func<Person, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger":
                    return p => p.Age < age;
                case "older":
                    return p => p.Age >= age;
                default:
                    return null;
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

