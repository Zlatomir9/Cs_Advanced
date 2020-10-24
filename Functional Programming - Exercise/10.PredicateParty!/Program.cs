using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                string criteria = tokens[1];

                if (action == "Remove")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            names = names.Where(n => !n.StartsWith(tokens[2])).ToList();
                            break;
                        case "EndsWith":
                            names = names.Where(n => !n.EndsWith(tokens[2])).ToList();
                            break;
                        case "Length":
                            names = names.Where(n => n.Length != int.Parse(tokens[2])).ToList();
                            break;
                    }
                }
                else if (action == "Double")
                {
                    List<string> matchedCriteria = new List<string>();
                    switch (criteria)
                    {
                        case "StartsWith":
                            matchedCriteria = names.Where(n => n.StartsWith(tokens[2])).ToList();
                            break;
                        case "EndsWith":
                            matchedCriteria = names.Where(n => n.EndsWith(tokens[2])).ToList();
                            break;
                        case "Length":
                            matchedCriteria = names.Where(n => n.Length == int.Parse(tokens[2])).ToList();
                            break;
                    }

                    foreach (var name in matchedCriteria)
                    {
                        var index = names.FindIndex(n => n == name);
                        names.Insert(index, name);
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(String.Join(", ", names));
                Console.WriteLine(" are going to the party!");    
            }
        }
    }
}
