using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (lengths[0] > 0 && lengths[1] > 0)
            {
                for (int i = 0; i < lengths[0]; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    firstSet.Add(n);
                }

                for (int i = 0; i < lengths[1]; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    secondSet.Add(n);
                }
            }           
                Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
