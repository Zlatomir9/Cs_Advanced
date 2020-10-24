using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();

            string[] files = Directory.GetFiles(directoryPath);

            decimal sum = 0;

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                sum += file.Length;
            }

            decimal sumMB = (sum / 1024) / 1024;

            using (var result = new StreamWriter("../../../Output.txt"))
            {
                result.Write($"{sumMB:f14}");
            }
        }
    }
}
