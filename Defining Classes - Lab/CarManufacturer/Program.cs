using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string tiresInput = Console.ReadLine();
            Dictionary<int, List<Tire>> tiresInfo = new Dictionary<int, List<Tire>>();

            int key = 0;

            while (tiresInput != "No more tires")
            {
                var tokens = tiresInput.Split();
                List<Tire> tires = new List<Tire>();

                for (int i = 0; i < tokens.Length; i+=2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    tires.Add(tire);
                }

                tiresInfo.Add(key, tires);
                key++;

                tiresInput = Console.ReadLine();
            }

            string enginesInput = Console.ReadLine();
            List<Engine> engines = new List<Engine>();

            while (enginesInput != "Engines done")
            {
                var tokens = enginesInput.Split();

                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int horsePower = int.Parse(tokens[i]);
                    double cubiCapacity = double.Parse(tokens[i + 1]);
                    Engine engine = new Engine(horsePower, cubiCapacity);
                    engines.Add(engine);
                }

                enginesInput = Console.ReadLine();
            }

            string carInfo = Console.ReadLine();

            List<Car> cars = new List<Car>();

            while (carInfo != "Show special")
            {
                string[] splitted = carInfo.Split();

                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);
                Engine engine = engines[engineIndex];
                List<Tire> tires = tiresInfo[tiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);

                cars.Add(car);

                carInfo = Console.ReadLine();
            }

            List<Car> specialCars = cars.Where(x => x.FuelQuantity >= x.FuelQuantity - (x.FuelConsumption * 1 / 5)
                                            && x.Year >= 2017
                                            && x.Engine.HorsePower >= 330
                                            && x.Tires.Sum(y => y.Pressure) >= 9
                                            && x.Tires.Sum(y => y.Pressure) <= 10)
                                            .ToList();

            foreach (var car in specialCars)
            {
                car.FuelQuantity = car.FuelQuantity - (car.FuelConsumption * 1 / 5);
                Console.WriteLine($"Make: {car.Make}" +
                    $"\nModel: {car.Model}" +
                    $"\nYear: {car.Year}" +
                    $"\nHorsePowers: {car.Engine.HorsePower}" +
                    $"\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
