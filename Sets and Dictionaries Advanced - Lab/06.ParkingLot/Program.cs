using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splitted = input.Split(", ");

                if (splitted[0] == "IN")
                {
                    cars.Add(splitted[1]);
                }
                else if (splitted[0] == "OUT")
                {
                    if (cars.Contains(splitted[1]))
                    {
                        cars.Remove(splitted[1]);
                    }
                }

                input = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
