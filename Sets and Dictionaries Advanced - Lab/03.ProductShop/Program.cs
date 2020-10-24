using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] splitted = input.Split(", ");

                if (!shops.ContainsKey(splitted[0]))
                {
                    shops.Add(splitted[0], new Dictionary<string, double>());
                }

                shops[splitted[0]].Add(splitted[1], double.Parse(splitted[2]));

                input = Console.ReadLine();
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
