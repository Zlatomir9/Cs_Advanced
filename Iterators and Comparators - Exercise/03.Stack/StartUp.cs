using System;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommand[0] == "Push")
                {
                    int[] elements = splittedCommand.Skip(1).Select(i => i.Split(',').First()).Select(int.Parse).ToArray();
                    stack.Push(elements);
                }
                else if (splittedCommand[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
