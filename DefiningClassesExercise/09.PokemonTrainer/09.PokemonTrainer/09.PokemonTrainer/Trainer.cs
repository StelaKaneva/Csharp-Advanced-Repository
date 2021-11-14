using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.numberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int numberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
