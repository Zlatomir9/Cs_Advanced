using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\Demo", @"D:\FolderToExtract\newZip.zip");
            ZipFile.ExtractToDirectory(@"D:\FolderToExtract\newZip.zip", @"D:\DemoResult");
        }
    }
}
