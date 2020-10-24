using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                numbers.Add(element);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(numbers);
            Console.WriteLine(box.Count(elementToCompare));
        }
    }
}
