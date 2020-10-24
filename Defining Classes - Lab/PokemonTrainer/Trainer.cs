using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        public Trainer(string name, int numberOfBadges, List<Pokemon> collectionOfPokemons)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            CollectionOfPokemons = collectionOfPokemons;
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> CollectionOfPokemons { get; set; }
    }
}
