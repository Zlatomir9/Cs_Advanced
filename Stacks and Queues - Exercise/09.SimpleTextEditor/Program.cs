using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationsCount = int.Parse(Console.ReadLine());

            var text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push(text.ToString());

            for (int i = 0; i < operationsCount; i++)
            {
                string[] currentOperation = Console.ReadLine().Split();
                int operationIndex = int.Parse(currentOperation[0]);

                if (operationIndex == 1)
                {
                    text.Append(currentOperation[1]);
                    stack.Push(text.ToString());
                }
                else if (operationIndex == 2)
                {
                    int length = int.Parse(currentOperation[1]);

                    text.Remove(text.Length - length, length);
                    stack.Push(text.ToString());
                }
                else if (operationIndex == 3)
                {
                    int indexToReturn = int.Parse(currentOperation[1]);

                    if (indexToReturn > 0 && indexToReturn <= text.Length)
                    {
                        Console.WriteLine(text[indexToReturn - 1]);
                    }
                }
                else if (operationIndex == 4)
                {
                    stack.Pop();
                    text = new StringBuilder();
                    text.Append(stack.Peek());
                }
            }
        }
    }
}
