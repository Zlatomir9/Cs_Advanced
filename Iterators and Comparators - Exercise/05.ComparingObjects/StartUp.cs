using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (command != "END")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person person = new Person(name, age, town);
                persons.Add(person);

                command = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person comparedPerson = persons[n - 1];

            int equal = 0;

            foreach (Person person in persons)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    equal++;
                }
            }

            if (equal == 1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                int notEqual = persons.Count - equal;
                Console.WriteLine($"{equal} {notEqual} {persons.Count}");
            }
        }
    }
}
