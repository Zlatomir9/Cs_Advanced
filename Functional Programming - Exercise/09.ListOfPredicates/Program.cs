using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbers = new List<int>();

            Func<int, List<int>, bool> isDivisible = (number, dividers) =>
            {
                for (int i = 0; i < dividers.Count; i++)
                {
                    if (number % dividers[i] != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 1; i <= rangeEnd; i++)
            {
                if (isDivisible(i, dividers))
                {
                     numbers.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
