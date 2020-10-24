using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../Input.txt"))
            {
                int index = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {
                        if (index % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
