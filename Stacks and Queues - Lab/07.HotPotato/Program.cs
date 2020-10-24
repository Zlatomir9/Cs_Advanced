using System;
using System.Collections;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childrens = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());

            Queue queue = new Queue(childrens);

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
