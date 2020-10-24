using System;
using System.Collections;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack stack = new Stack();

            int startIndex = 0;

            for (int i = 0; i < expression.Length; i++)
            {

                if (expression[i] == '(')
                {
                    stack.Push(i);
                }

                if (expression[i] == ')')
                {
                    startIndex = (int)stack.Pop();

                    Console.WriteLine(expression.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
