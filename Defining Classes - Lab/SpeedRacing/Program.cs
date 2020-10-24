using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                Car car = new Car(model: carInfo[0], fuelAmount: double.Parse(carInfo[1]), fuelComsumptionPerKilometer: double.Parse(carInfo[2]));

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                string carModel = tokens[1];
                int amountOfKm = int.Parse(tokens[2]);

                Car car = cars.FirstOrDefault(x => x.Model == carModel);

                car.Drive(amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
