using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int> asciiFunc = n => n.Select(c => (int)c).Sum();

            Func<List<string>, int, Func<string, int>, string> nameFunc = (names, length, func) => names.FirstOrDefault(n => func(n) >= length);

            string name = nameFunc(names, length, asciiFunc);
            Console.WriteLine(name);
        }
    }
}
