using System;
using System.Collections;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsCount = input[0];
            int elementsToRemove = input[1];
            int elementToFind = input[2];

            Queue queue = new Queue();

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < elementsCount; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                var arr = queue.ToArray();
                Console.WriteLine(arr.Min());
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
