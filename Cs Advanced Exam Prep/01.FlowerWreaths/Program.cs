using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<int> storedFlowers = new List<int>();

            int whreathsCount = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int result = lilies.Peek() + roses.Peek();

                if (result == 15)
                {
                    lilies.Pop();
                    roses.Dequeue();
                    whreathsCount++;
                }
                else if (result > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else if (result < 15)
                {
                    storedFlowers.Add(result);
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            whreathsCount += storedFlowers.Sum() / 15;

            if (whreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {whreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - whreathsCount} wreaths more!");
            }
        }
    }
}
