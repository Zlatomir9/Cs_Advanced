using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQunatity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodQunatity >= orders.Peek())
                {
                    foodQunatity -= orders.Dequeue();
                }
                else
                {
                    Console.Write("Orders left: ");

                    while (orders.Count > 0)
                    {
                        Console.Write($"{orders.Dequeue()} ");
                    }
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
