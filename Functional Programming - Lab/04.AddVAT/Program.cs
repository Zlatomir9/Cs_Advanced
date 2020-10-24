using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(x => x * 1.2M).ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
