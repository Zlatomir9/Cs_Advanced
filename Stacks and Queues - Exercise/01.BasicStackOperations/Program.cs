using System;
using System.Collections;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int stackCount = input[0];
            int elementsToPop = input[1];
            int elementToFind = input[2];

            Stack stack = new Stack();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < stackCount; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                var arr = stack.ToArray();
                Console.WriteLine(arr.Min());
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
