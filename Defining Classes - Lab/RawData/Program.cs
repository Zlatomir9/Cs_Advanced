using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4];

                int counter = 0;
                for (int k = 5; k < input.Length; k += 2)
                {
                    double tirePressure = double.Parse(input[k]);
                    int tireAge = int.Parse(input[k + 1]);

                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[counter] = tire;
                    counter++;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile" &&
                                             x.Tires.Any(p => p.Pressure < 1));

                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var flamableCars = cars.Where(x => x.Cargo.Type == "flamable" &&
                                              x.Engine.Power > 250);

                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
