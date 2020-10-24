using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> times = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!times.ContainsKey(input))
                {
                    times.Add(input, 1);
                }
                else
                {
                    times[input]++;
                }
            }

            foreach (var item in times)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
