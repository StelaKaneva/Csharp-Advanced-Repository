using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, int health, string element)
        {
            this.Name = name;
            this.Health = health;
            this.Element = element;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public string Element { get; set; }
    }
}
