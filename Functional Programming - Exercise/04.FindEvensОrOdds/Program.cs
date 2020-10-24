using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensОrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> range = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<int> numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            Func<string, List<int>, List<int>> getRange = (str, intr) =>
            {
                switch (str)
                {
                    case "odd": return intr.Where(n => n % 2 != 0).Select(n => n).ToList();
                    case "even": return intr.Where(n => n % 2 == 0).Select(n => n).ToList();
                    default: return null;
                }
            };

            List<int> result = getRange(command, numbers);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
