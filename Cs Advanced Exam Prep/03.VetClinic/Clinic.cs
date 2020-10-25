using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        public int Capacity { get; set; }

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public void Add(Pet pet) 
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name) 
        {
            if (pets.Any(x => x.Name == name))
            {
                Pet pet = pets.FirstOrDefault(x => x.Name == name);
                pets.Remove(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pet GetPet(string name, string owner) 
        {
            Pet pet = pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }

        public Pet GetOldestPet() 
        {
            int maxAge = int.MinValue;
            Pet pet = null;

            foreach (var animal in pets)
            {
                if (maxAge < animal.Age)
                {
                    maxAge = animal.Age;
                    pet = animal;
                }
            }
            return pet;
        }

        public int Count => pets.Count;

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
