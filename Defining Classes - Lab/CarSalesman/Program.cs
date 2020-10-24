using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split((' '), StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3)
                {
                    int value;
                    if (int.TryParse(engineInfo[2], out value))
                    {
                        engine.Displacement = value.ToString();
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engine.Displacement = engineInfo[2];
                    engine.Efficiency = engineInfo[3];
                }

                engines.Add(engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split((' '), StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                Engine engine = engines.FirstOrDefault(x => x.Model == carInfo[1]);
                Car car = new Car(carModel, engine);

                if (carInfo.Length == 3)
                {
                    int value;

                    if (int.TryParse(carInfo[2], out value))
                    {
                        car.Weight = value.ToString();
                    }
                    else
                    {
                        car.Color = carInfo[2];
                    }
                }
                else if (carInfo.Length == 4)
                {
                    car.Weight = carInfo[2];
                    car.Color = carInfo[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:" +
                    $"\n  {car.Engine.Model}:" +
                    $"\n    Power: {car.Engine.Power}" +
                    $"\n    Displacement: {car.Engine.Displacement}" +
                    $"\n    Efficiency: {car.Engine.Efficiency}" +
                    $"\n  Weight: {car.Weight}" +
                    $"\n  Color: {car.Color}");
            }
        }
    }
}
