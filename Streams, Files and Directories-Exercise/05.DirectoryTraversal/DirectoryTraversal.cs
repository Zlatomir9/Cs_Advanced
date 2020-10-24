using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> files = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo info = new DirectoryInfo("../../../");

            var allFiles = info.GetFiles();

            foreach (var item in allFiles)
            {
                if (!files.ContainsKey(item.Extension))
                {
                    files.Add(item.Extension, new Dictionary<string, double>());
                }

                files[item.Extension].Add(item.Name, item.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report.txt"))
            {
                foreach (var file in files.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(file.Key);
                    foreach (var currentFile in file.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{currentFile.Key} - {currentFile.Value}kb");
                    }
                }
            }
        }
    }
}
