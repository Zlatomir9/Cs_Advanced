using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minValue = nums =>
                {
                    int minValue = int.MaxValue;

                    foreach (var num in numbers)
                    {
                        if (num < minValue)
                        {
                            minValue = num;
                        }
                    }
                    return minValue;
                };

            Console.WriteLine(minValue(numbers));
        }
    }
}
