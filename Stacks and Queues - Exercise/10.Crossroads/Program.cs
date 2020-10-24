using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCars = 0;

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int greenLightLeft = greenLightDuration;

                    while (cars.Count > 0)
                    {
                        string currentCar = cars.Peek();

                        if (currentCar.Length < greenLightLeft)
                        {
                            cars.Dequeue();
                            greenLightLeft -= currentCar.Length;
                            passedCars++;
                        }
                        else if (currentCar.Length == greenLightLeft)
                        {
                            cars.Dequeue();
                            passedCars++;
                            break;
                        }
                        else if (currentCar.Length <= greenLightLeft + freeWindowDuration)
                        {
                            cars.Dequeue();
                            passedCars++;
                            break;
                        }
                        else if (currentCar.Length > greenLightLeft + freeWindowDuration)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {currentCar[greenLightLeft + freeWindowDuration]}.");
                            return;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
