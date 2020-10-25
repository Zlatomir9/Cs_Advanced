using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int matches = 0;

            while (true)
            {
                if ((males.Peek() > 0 && males.Peek() % 25 != 0)
                    && (females.Peek() > 0 && females.Peek() % 25 != 0))
                {
                    if (males.Peek() == females.Peek())
                    {
                        males.Pop();
                        females.Dequeue();
                        matches++;
                        if (males.Count == 0 || females.Count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        females.Dequeue();
                        males.Push(males.Pop() - 2);
                        if (females.Count <= 0)
                        {
                            break;
                        }
                    }
                }
                if (males.Peek() % 25 == 0 && males.Peek() != 0 && males.Count > 1)
                {
                    males.Pop();
                    males.Pop();
                    if (males.Count <= 0)
                    {
                        break;
                    }
                }
                if (females.Peek() % 25 == 0 && females.Peek() != 0 && females.Count > 1)
                {
                    females.Dequeue();
                    females.Dequeue();
                    if (females.Count <= 0)
                    {
                        break;
                    }
                }
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    if (males.Count <= 0)
                    {
                        break;
                    }
                }
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    if (females.Count <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count <= 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.Write("Males left: ");
                Console.WriteLine(String.Join(", ", males));
            }
            if (females.Count <= 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.Write("Females left: ");
                Console.WriteLine(String.Join(", ", females));
            }
        }
    }
}
