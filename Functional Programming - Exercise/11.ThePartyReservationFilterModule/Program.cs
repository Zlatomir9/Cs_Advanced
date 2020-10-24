using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            List<string> filters = new List<string>();

            while (command != "Print")
            {
                string[] tokens = command.Split(';');
                string operation = tokens[0];
                string filterType = tokens[1];
                string parameter = tokens[2];

                if (operation == "Add filter")
                {
                    filters.Add($"{filterType};{parameter}");
                }
                else if (operation == "Remove filter")
                {
                    filters.Remove($"{filterType};{parameter}");
                }

                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] splitted = filter.Split(';');
                string filterType = splitted[0];
                string parameter = splitted[1];

                if (filterType == "Starts with")
                {
                    names = names.Where(n => !n.StartsWith(parameter)).ToList();
                }
                else if (filterType == "Ends with")
                {
                    names = names.Where(n => !n.EndsWith(parameter)).ToList();
                }
                else if (filterType == "Length")
                {
                    names = names.Where(n => n.Length != int.Parse(parameter)).ToList();
                }
                else if (filterType == "Contains")
                {
                    names = names.Where(n => !n.Contains(parameter)).ToList();
                }
            }

            Console.WriteLine(String.Join(' ', names));
        }
    }
}
