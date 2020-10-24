using System;
using System.Collections;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Queue queue = new Queue();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
