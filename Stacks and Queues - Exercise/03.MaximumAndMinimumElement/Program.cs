using System;
using System.Collections;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack stack = new Stack();

            for (int i = 0; i < n; i++)
            {
                int[] querie = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (querie[0] == 1)
                {
                    stack.Push(querie[1]);
                }
                else if (querie[0] == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (querie[0] == 3 && stack.Count > 0)
                {
                    var arr = stack.ToArray();
                    Console.WriteLine(arr.Max());
                }
                else if (querie[0] == 4 && stack.Count > 0)
                {
                    var arr = stack.ToArray();
                    Console.WriteLine(arr.Min());
                }
            }

            while (stack.Count > 1)
            {
                Console.Write(stack.Pop() + ", ");
            }
            Console.Write(stack.Pop());
        }
    }
}
