using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int taskToKill = int.Parse(Console.ReadLine());

            while (tasks.Count > 0 && threads.Count > 0)
            {
                if (tasks.Peek() != taskToKill)
                {
                    if (threads.Peek() >= tasks.Peek())
                    {
                        threads.Dequeue();
                        tasks.Pop();
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
                else
                {
                    tasks.Pop();
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
                    Console.WriteLine(String.Join(' ', threads));
                    break;
                }
            }
        }
    }
}
