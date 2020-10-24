using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reversFunc = x =>
            {
                List<int> reversed = new List<int>();

                for (int i = x.Count - 1; i >= 0; i--)
                {
                    reversed.Add(x[i]);
                }

                return reversed;
            };

            input = reversFunc(input);

            Func<int, bool> predicate = x => x % divider != 0;

            Console.WriteLine(String.Join(' ', input.Where(predicate)));
        }
    }
}
