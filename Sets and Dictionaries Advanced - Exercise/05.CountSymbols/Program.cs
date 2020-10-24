using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 1);
                }
                else
                {
                    chars[input[i]]++;
                }
            }

            foreach (var item in chars.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
