using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Human
    {
        private bool isAlive;

        public Human(string name): this()
        {
            //isAlive = true;
            Name = name;
        }

        public Human()
        {
            isAlive = true;
            //isAlive = false;
            //Name = "Nyama";

            isAlive = true;
        }

        public Human(string name, int age) : this (name)
        {
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat()
        {
            if (isAlive)
            {
                Console.WriteLine("I am eating");
            }
            else
            {
                Console.WriteLine("Ne moga");
            }
        }

        public void Die()
        {
            this.isAlive = false;
        }
    }
}
