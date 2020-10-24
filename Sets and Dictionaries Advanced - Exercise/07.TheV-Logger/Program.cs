using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> followers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] splitted = input.Split();

                if (splitted[1] == "joined" && !followers.ContainsKey(splitted[0]))
                {
                    string vlogger = splitted[0];
                    {
                        followers.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        followers[vlogger].Add("followers", new HashSet<string>());
                        followers[vlogger].Add("following", new HashSet<string>());
                    }
                }

                else if (splitted[1] == "followed")
                {
                    string follower = splitted[0];
                    string vloggerFollowing = splitted[2];

                    if ((followers.ContainsKey(follower)) 
                        && (followers.ContainsKey(vloggerFollowing)) 
                        && (follower != vloggerFollowing))
                    {
                        followers[follower]["following"].Add(vloggerFollowing);
                        followers[vloggerFollowing]["followers"].Add(follower);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {followers.Keys.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in followers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}
