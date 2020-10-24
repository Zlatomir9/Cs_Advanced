using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person member) 
        {
            People.Add(member);
        }

        public Person GetOldest() 
        {
            int maxAge = int.MinValue;
            Person person = null;

            foreach (var member in People)
            {
                if (member.Age > maxAge)
                {
                    maxAge = member.Age;
                    person = member;
                }
            }

            return person;
        }

        public List<Person> GetOlderThan30() 
        {
            People = People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            return People;
        }
    }
}
