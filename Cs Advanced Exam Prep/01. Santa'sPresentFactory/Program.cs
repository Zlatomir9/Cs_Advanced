using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> toys = new Dictionary<string, int>();

            while (materials.Count > 0 && magicLevel.Count > 0)
            {
                if (materials.Peek() == 0 || magicLevel.Peek() == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }
                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();
                    }
                    continue;
                }
                
                int result = materials.Peek() * magicLevel.Peek();

                if ((result == 150)
                    || (result == 250)
                    || (result == 300)
                    || (result == 400))
                {
                    switch (result)
                    {
                        case 150:
                            if (!toys.ContainsKey("Doll"))
                            {
                                toys.Add("Doll", 1);
                            }
                            else
                            {
                                toys["Doll"]++;
                            }
                            break;
                        case 250:
                            if (!toys.ContainsKey("Wooden train"))
                            {
                                toys.Add("Wooden train", 1);
                            }
                            else
                            {
                                toys["Wooden train"]++;
                            }
                            break;
                        case 300:
                            if (!toys.ContainsKey("Teddy bear"))
                            {
                                toys.Add("Teddy bear", 1);
                            }
                            else
                            {
                                toys["Teddy bear"]++;
                            }
                            break;
                        case 400:
                            if (!toys.ContainsKey("Bicycle"))
                            {
                                toys.Add("Bicycle", 1);
                            }
                            else
                            {
                                toys["Bicycle"]++;
                            }
                            break;
                    }

                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (result < 0)
                {
                    materials.Push(materials.Pop() + magicLevel.Dequeue());
                }
                else if (result > 0)
                {
                    magicLevel.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }
                
            }

            if ((toys.ContainsKey("Bicycle") && toys.ContainsKey("Teddy bear"))
                || (toys.ContainsKey("Doll") && toys.ContainsKey("Wooden train")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {String.Join(", ", materials)}");
            }
            if (magicLevel.Count > 0)
            {
                Console.WriteLine($"Magic left: {String.Join(", ", magicLevel)}");
            }

            foreach (var toy in toys.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{toy.Key}: {toy.Value}");
            }
        }
    }
}
