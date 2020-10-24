using System;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            Action<string> print = name => Console.WriteLine(name);
            names.ForEach(name => print(name)); 
        }
    }
}
