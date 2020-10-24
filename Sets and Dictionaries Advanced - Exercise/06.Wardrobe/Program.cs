using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string[] clothing = input[1].Split(",");

                if (!clothes.ContainsKey(input[0]))
                {
                    clothes.Add(input[0], new Dictionary<string, int>());
                }

                for (int k = 0; k < clothing.Length; k++)
                {
                    if (!clothes[input[0]].ContainsKey(clothing[k]))
                    {
                        clothes[input[0]].Add(clothing[k], 1);
                    }
                    else
                    {
                        clothes[input[0]][clothing[k]]++;
                    }
                }
            }

            string[] searchedClothes = Console.ReadLine().Split();

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var piece in item.Value)
                {
                    Console.Write($"* {piece.Key} - {piece.Value}");

                    if (item.Key == searchedClothes[0] && piece.Key == searchedClothes[1])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
