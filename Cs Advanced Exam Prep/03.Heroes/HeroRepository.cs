using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository() 
        {
            heroes = new List<Hero>();
        }

        public void Add(Hero hero) 
        {
            heroes.Add(hero);
        }

        public void Remove(string name) 
        {
            Hero hero = heroes.FirstOrDefault(x => x.Name == name);
            heroes.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength() 
        {
            Hero heroWithHighestStrength = heroes.OrderByDescending(x => x.Item.Strength).First();
            return heroWithHighestStrength;
        }

        public Hero GetHeroWithHighestAbility() 
        {
            Hero heroWithHighestAbility = heroes.OrderByDescending(x => x.Item.Ability).First();
            return heroWithHighestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroWithHighestIntelligence = heroes.OrderByDescending(x => x.Item.Intelligence).First();
            return heroWithHighestIntelligence;
        }

        public int Count => heroes.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (heroes.Count > 0)
            {
                foreach (var hero in heroes)
                {
                    sb.AppendLine($"{hero}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
