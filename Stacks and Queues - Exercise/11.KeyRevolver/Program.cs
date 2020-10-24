using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int shots = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();
                value -= bulletPrice;
                shots++;

                if (bullets.Count > 0 && shots == gunBarrelSize)
                {
                    Console.WriteLine("Reloading!");
                    shots = 0;
                }

                if (locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${value}");
                    return;
                }
            }

            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
    }
}
