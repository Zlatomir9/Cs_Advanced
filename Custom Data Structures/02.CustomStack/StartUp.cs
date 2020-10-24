using System;

namespace _02.CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            for (int i = 1; i < 5; i++)
            {
                stack.Push(i);
            }

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(stack.Peek());
            //    stack.Pop();
            //}

            stack.ForEach(Console.WriteLine);
        }
    }
}
