using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (cups.Peek() > bottles.Peek())
                {
                    int currCup = cups.Dequeue();
                    currCup -= bottles.Pop();
                    cups.Enqueue(currCup);

                    for (int i = 0; i < cups.Count - 1; i++)
                    {
                        cups.Enqueue(cups.Dequeue());
                    }
                }
                else
                {
                    wastedWater += bottles.Pop() - cups.Dequeue();
                }
            }

            if (cups.Count == 0)
            {
                Console.Write($"Bottles: ");
                Console.WriteLine(String.Join(' ', bottles));
            }
            else if (bottles.Count == 0)
            {
                Console.Write($"Cups: ");
                Console.WriteLine(String.Join(' ', cups));
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
