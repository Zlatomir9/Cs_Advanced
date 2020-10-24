using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                {
                    if ((stack.Peek() == '(' && input[i] == ')')
                        || (stack.Peek() == '[' && input[i] == ']')
                        || stack.Peek() == '{' && input[i] == '}')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
