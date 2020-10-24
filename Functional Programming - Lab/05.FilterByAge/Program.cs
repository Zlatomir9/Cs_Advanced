using System;

namespace _05.FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                people[i] = new Person { Name = name, Age = age };
            }

            string condition = Console.ReadLine();
            int searchedAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = GetCondition(condition, searchedAge);
            Action<Person> printerDelegate = Printer(format);

            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }
        }

        static Func<Person, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "older": return a => a.Age >= age;
                case "younger": return a => a.Age < age;

                default:
                    return null;
            }
        }

        static Action<Person> Printer(string format) 
        {
            switch (format)
            {
                case "name age": return a => { Console.WriteLine($"{a.Name} - {a.Age}"); };
                case "name": return a => { Console.WriteLine($"{a.Name}"); };
                case "age": return a => { Console.WriteLine($"{a.Age}"); };
                default: return null;
            }
        }
    }
}
