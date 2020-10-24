using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();

                list.Add(value);
            }

            string elementToCompare = Console.ReadLine();

            Box<string> box = new Box<string>(list);

            Console.WriteLine(box.Count(elementToCompare));
        }
    }
}
