using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                if (command == "Play" && songs.Count > 0)
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string songName = command.Remove(0, 4);

                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            if (songs.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
