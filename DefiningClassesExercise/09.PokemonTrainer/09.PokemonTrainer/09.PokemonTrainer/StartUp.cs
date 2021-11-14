using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string trainerInput = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (trainerInput != "Tournament")
            {
                string[] tokens = trainerInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);
                Trainer currentTrainer = new Trainer(trainerName);
                currentTrainer.Pokemons.Add(currentPokemon);

                bool wasAdded = false;

                foreach (var trainer in trainers)
                {
                    if (trainer.Name == trainerName)
                    {
                        trainer.Pokemons.Add(currentPokemon);
                        wasAdded = true;
                        break;
                    }
                }
                if (!wasAdded)
                {
                    trainers.Add(currentTrainer);
                }

                trainerInput = Console.ReadLine();
            }

            string elementInput = Console.ReadLine();

            while (elementInput != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    Trainer currentTrainer = trainers[i];

                    if (currentTrainer.Pokemons.Any(p => p.Element == elementInput && p.Health > 0))
                    {
                        currentTrainer.numberOfBadges++;
                    }
                    else
                    {
                        int count = currentTrainer.Pokemons.Count;

                        for (int j = 0; j < count; j++)
                        {
                            Pokemon pokemon = currentTrainer.Pokemons[j];
                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                currentTrainer.Pokemons.Remove(pokemon);
                                j--;
                                if (j < 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                
                elementInput = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.numberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.numberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
