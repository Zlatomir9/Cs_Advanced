using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person person = new Person(name, age);
                people.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
