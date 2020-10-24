using System;
using System.IO;

namespace _02.LineNumbers
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
                        writer.WriteLine($"{index+1}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
