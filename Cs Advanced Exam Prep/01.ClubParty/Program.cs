using System;
using System.Collections.Generic;

namespace _01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> elements = new Stack<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Queue<string> halls = new Queue<string>();
            List<int> groups = new List<int>();
            int currentCapacity = 0;

            while (elements.Count > 0)
            {
                string currentElement = elements.Pop();

                bool isNumber = int.TryParse(currentElement, out int number);

                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity + number > capacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", groups)}");
                        groups.Clear();
                        currentCapacity = 0;
                    }
                    if (halls.Count > 0)
                    {
                        groups.Add(number);
                        currentCapacity += number;
                    }
                }
            }
        }
    }
}
