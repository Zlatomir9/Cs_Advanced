using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            Action<string> makeOperation = (command) =>
            {
                switch (command)
                {
                    case "add": numbers = numbers.Select(n => n + 1).ToList();
                        break;
                    case "multiply": numbers = numbers.Select(n => n * 2).ToList();
                        break;
                    case "subtract": numbers = numbers.Select(n => n - 1).ToList();
                        break;
                    case "print": Console.WriteLine(String.Join(" ", numbers));
                        break;
                    default:
                        break;
                }
            };

            while (command != "end")
            {
                makeOperation(command);
                command = Console.ReadLine();
            }
        }
    }
}
