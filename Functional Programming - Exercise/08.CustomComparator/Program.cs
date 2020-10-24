using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers, (x, y) =>
            {
                int sorter = 0;
                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }
                else if (y % 2 == 0 && x % 2 != 0)
                {
                    sorter = 1;
                }
                else
                {
                    sorter = x - y;
                }

                return sorter;
            });
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
