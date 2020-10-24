using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> matchedWords = new Dictionary<string, int>();
            string[] words = File.ReadAllText("../../../words.txt").ToLower().Split($"{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries);

            using (var reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] text = line.ToLower().Split(new char[] { ' ', ',', '-', '.', '?', '!' },
                                    StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Count(); i++)
                    {
                        for (int k = 0; k < text.Count(); k++)
                        {
                            if (text[k] == words[i])
                            {
                                if (!matchedWords.ContainsKey(words[i]))
                                {
                                    matchedWords.Add(words[i], 1);
                                }
                                else
                                {

                                    matchedWords[words[i]]++;
                                }
                            }
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var item in matchedWords.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../areEqual.txt"))
            {
                var areEquals = File.ReadLines("../../../actualResult.txt").SequenceEqual(File.ReadLines("../../../expectedResult.txt"));
                if(areEquals)
                {
                    writer.Write(areEquals);
                }
            }
        }
    }
}
