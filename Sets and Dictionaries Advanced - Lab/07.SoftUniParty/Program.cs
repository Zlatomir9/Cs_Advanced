using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string guestsList = Console.ReadLine();

            while (guestsList != "PARTY")
            {
                guests.Add(guestsList);

                guestsList = Console.ReadLine();
            }

            string guestWhoCame = Console.ReadLine();

            while (guestWhoCame != "END")
            {
                if (guests.Contains(guestWhoCame))
                {
                    guests.Remove(guestWhoCame);
                }

                guestWhoCame = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests.OrderByDescending(x => char.IsDigit(x[0])))
            {
                Console.WriteLine(guest);
            }
        }
    }
}
