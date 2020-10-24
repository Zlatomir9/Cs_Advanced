using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("../../../text.txt");

            string[] newLines = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                string line = text[i];
                int letters = CountOfLetters(line);
                int marks = CountPunctuationMarks(line);

                newLines[i] = $"Line {i+1}: {line} ({letters})({marks})";
            }

            File.WriteAllLines("../../../output.txt", newLines);
        }

        static int CountOfLetters(string line) 
        {
            int count = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    count++;
                }
            }

            return count;
        }

        static int CountPunctuationMarks(string line) 
        {
            int count = 0;
            char[] punctuationMarks = new char[] {'.', ',', '!', '?', '-', '\'', ';', ':' };

            for (int i = 0; i < line.Length; i++)
            {
                if (punctuationMarks.Contains(line[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
