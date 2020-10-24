using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            
            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] splitted = command.Split();

                string trainerName = splitted[0];
                string pokemonName = splitted[1];
                string pokemonElement = splitted[2];
                int pokemonHealth = int.Parse(splitted[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());

                if (trainers.Any(x => x.Name == trainerName))
                {
                    int index = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[index].CollectionOfPokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(trainer);
                    int index = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[index].CollectionOfPokemons.Add(pokemon);
                }

                command = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Fire":
                        BadgesCounter(input, trainers);
                        break;
                    case "Water":
                        BadgesCounter(input, trainers);
                        break;
                    case "Electricity":
                        BadgesCounter(input, trainers);
                        break;
                }

                if (trainers.Any(x => x.CollectionOfPokemons.Any(y => y.Health <= 0)))
                {
                    PokemonsRemove(trainers);
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.CollectionOfPokemons.Count}");
            }
        }

        static void BadgesCounter(string input, List<Trainer> trainers) 
        {
            foreach (var trainer in trainers)
            {
                if (trainer.CollectionOfPokemons.Any(x => x.Element == input))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in trainer.CollectionOfPokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
            }
        }

        static void PokemonsRemove(List<Trainer> trainers) 
        {
            foreach (var trainer in trainers)
            {
                if (trainer.CollectionOfPokemons.Any(x => x.Health <= 0))
                {
                    int index = trainer.CollectionOfPokemons.FindIndex(x => x.Health <= 0);
                    trainer.CollectionOfPokemons.RemoveAt(index);
                }
            }
        }
    }
}
