using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelComsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelComsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int amountOfKm)
        {
            if (FuelConsumptionPerKilometer * amountOfKm <= FuelAmount)
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountOfKm;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
