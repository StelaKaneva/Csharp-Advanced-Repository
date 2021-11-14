using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person pesho = new Person("Pesho", 20);
            //Console.WriteLine($"{pesho.Name} {pesho.Age}");

            //Person gosho = new Person("Gosho", 18);
            //Console.WriteLine($"{gosho.Name} {gosho.Age}");

            //Person stamat = new Person("Stamat", 43);
            //Console.WriteLine($"{stamat.Name} {stamat.Age}");

            Person person1 = new Person();
            Person person2 = new Person(12);
            Person person3 = new Person("Stoyan", 24);

        }
    }
}
