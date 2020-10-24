using System;
using System.Collections;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue queue = new Queue();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    queue.Enqueue(digits[i]);
                }
            }

            while (queue.Count > 1)
            {
                Console.Write(queue.Dequeue() + ", ");
            }
            Console.Write(queue.Dequeue());
        }
    }
}
