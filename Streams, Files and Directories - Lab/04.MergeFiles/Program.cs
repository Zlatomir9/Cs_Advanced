using System;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader firstFile = new StreamReader("../../../FileOne.txt"))
            {
                using (StreamReader secondFile = new StreamReader("../../../FileTwo.txt"))
                {
                    using (StreamWriter thirdFile = new StreamWriter("../../../Otput.txt"))
                    {
                        string[] firstNums = firstFile.ReadToEnd().Split($"{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        string[] secondNums = secondFile.ReadToEnd().Split($"{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries).ToArray();

                        for (int i = 0; i < firstNums.Length; i++)
                        {
                            thirdFile.WriteLine(firstNums[i]);
                            thirdFile.WriteLine(secondNums[i]);
                        }
                    }
                }
            }
        }
    }
}
