using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharoDog = new Dog();
            sharoDog.Name = "Sharo";
            sharoDog.Years = 7;

            Console.WriteLine(sharoDog.Name);
            Console.WriteLine(sharoDog.HadOwner);//False по deffault

            Dog peshoDog = new Dog();
            peshoDog.Name = "Pesho";

            peshoDog = sharoDog;

            Console.WriteLine(peshoDog.Name);// Sharo
        }
    }
}
