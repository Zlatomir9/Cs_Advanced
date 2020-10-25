using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;
        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            rabbits = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            if (rabbits.Any(x => x.Name == name))
            {
                Rabbit rabbit = rabbits.FirstOrDefault(y => y.Name == name);
                rabbits.Remove(rabbit);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveSpecies(string species)
        {
            if (rabbits.Any(x => x.Species == species))
            {
                Rabbit[] removedRabbits = rabbits.Where(x => x.Species == species).ToArray();
                for (int i = 0; i < removedRabbits.Length; i++)
                {
                    if (rabbits[i] == removedRabbits[i])
                    {
                        rabbits.Remove(rabbits[i]);
                    }
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            if (rabbits.Any(x => x.Name == name))
            {
                Rabbit rabbit = rabbits.FirstOrDefault(x => x.Name == name);
                rabbit.Available = false;
                return rabbit;
            }
            else
            {
                return null;
            }
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            if (rabbits.Any(x=> x.Species == species))
            {
                Rabbit[] soldRabbits = rabbits.Where(x => x.Species == species).ToArray();

                foreach (var rabbit in rabbits)
                {
                    if (rabbit.Species == species)
                    {
                        rabbit.Available = false;
                    }
                }
                return soldRabbits;
            }
            else
            {
                return null;
            }   
        }

        public int Count => rabbits.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (var rabbit in rabbits.Where(x => x.Available == true))
            {
                sb.AppendLine($"{rabbit}");
            }

            return sb.ToString().Trim();
        }
    }
}
