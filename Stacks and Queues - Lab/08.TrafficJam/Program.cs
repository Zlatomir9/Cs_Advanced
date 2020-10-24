using System;
using System.Collections;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            int passedCount = 0;

            Queue carQueue = new Queue();

            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carQueue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{carQueue.Dequeue()} passed!");
                        passedCount++;
                    }
                }
                else
                {
                    carQueue.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
