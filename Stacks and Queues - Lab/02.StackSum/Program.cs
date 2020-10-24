using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] splitted = command.Split();

                if (splitted[0] == "add")
                {
                    stack.Push(int.Parse(splitted[1]));
                    stack.Push(int.Parse(splitted[2]));
                }
                else if (splitted[0] == "remove")
                {
                    if (int.Parse(splitted[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(splitted[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
