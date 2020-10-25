using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> pouch = new Dictionary<string, int>();
            pouch.Add("Datura Bombs", 0);
            pouch.Add("Cherry Bombs", 0);
            pouch.Add("Smoke Decoy Bombs", 0);

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int result = bombEffects.Peek() + bombCasings.Peek();

                if (result == 40 || result == 60 || result == 120)
                {
                    switch (result)
                    {
                        case 40:
                            pouch["Datura Bombs"]++;
                            break;
                        case 60:
                            pouch["Cherry Bombs"]++;
                            break;
                        case 120:
                            pouch["Smoke Decoy Bombs"]++;
                            break;
                    }
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }

                if (pouch["Datura Bombs"] >= 3 && pouch["Cherry Bombs"] >= 3 && pouch["Smoke Decoy Bombs"] >= 3)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }
            }

            if (pouch["Datura Bombs"] < 3 || pouch["Cherry Bombs"] < 3 || pouch["Smoke Decoy Bombs"] < 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count <= 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ", bombEffects)}");
            }
            if (bombCasings.Count <= 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", bombCasings)}");
            }

            foreach (var bomb in pouch.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
