using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> values = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                values.Add(value);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<string> box = new Box<string>(values);

            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
