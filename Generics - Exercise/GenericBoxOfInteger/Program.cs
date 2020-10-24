using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(current);
                Console.WriteLine(box);
            }
        }
    }
}
