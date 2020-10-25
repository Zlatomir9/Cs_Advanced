using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> presents;
        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            presents = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public void Add(Present present) 
        {
            if (Capacity > presents.Count)
            {
                presents.Add(present);
            }
        }

        public bool Remove(string name) 
        {
            if (presents.Any(x => x.Name == name))
            {
                Present present = presents.FirstOrDefault(x => x.Name == name);
                presents.Remove(present);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Present GetHeaviestPresent() 
        {
            Present present = presents.OrderByDescending(x => x.Weight).FirstOrDefault();
            return present;
        }

        public Present GetPresent(string name) 
        {
            Present present = presents.FirstOrDefault(x => x.Name == name);
            return present;
        }

        public int Count => presents.Count;

        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            foreach (var present in presents)
            {
                sb.AppendLine($"{present.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
