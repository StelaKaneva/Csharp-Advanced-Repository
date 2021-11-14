using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Pesho", 15);
            Console.WriteLine(human.Name);
            Human deadHuman = new Human();
            Console.WriteLine(deadHuman.Name);
            human.Eat();
            human.Die();
            human.Eat();
        }
    }
}
