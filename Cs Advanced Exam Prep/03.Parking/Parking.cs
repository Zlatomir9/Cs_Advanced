using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }

        public void Add(Car car)
        {
            if (Capacity > cars.Count)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (cars.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                cars.Remove(car);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Car GetLatestCar() 
        {
            if (cars.Count > 0)
            {
                Car latestCar = null;
                int latestYear = int.MinValue;
                foreach (var car in cars)
                {
                    if (car.Year > latestYear)
                    {
                        latestYear = car.Year;
                        latestCar = car;
                    }
                }
                return latestCar;
            }
            else
            {
                return null;
            }
        }

        public Car GetCar(string manufacturer, string model) 
        {
            if (cars.Any(x=> x.Manufacturer == manufacturer && x.Model == model))
            {
                Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                return car;
            }
            else
            {
                return null;
            }
        }

        public int Count => cars.Count;

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in cars)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
