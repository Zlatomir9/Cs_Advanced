using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksCount = 0;
            int sum = 0;

            while (clothes.Count > 0)
            {
                sum += clothes.Peek();

                if (sum <= rackCapacity)
                {
                    if (clothes.Count == 1)
                    {
                        racksCount++;
                    }

                    clothes.Pop();
                }
                else
                {
                    sum = 0;
                    racksCount++;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
