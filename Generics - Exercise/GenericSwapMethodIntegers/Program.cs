using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                values.Add(currentValue);
            }

            Box<int> box = new Box<int>(values);

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
