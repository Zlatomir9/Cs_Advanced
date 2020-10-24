using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> interns = new Dictionary<string, Dictionary<string, int>>();

            string contestData = Console.ReadLine();

            while (contestData != "end of contests")
            {
                string[] splitted = contestData.Split(":");
                string contest = splitted[0];
                string password = splitted[1];

                contests.Add(contest, password);

                contestData = Console.ReadLine();
            }

            string internData = Console.ReadLine();

            while (internData != "end of submissions")
            {
                string[] splitted = internData.Split("=>");
                string contest = splitted[0];
                string password = splitted[1];
                string username = splitted[2];
                int points = int.Parse(splitted[3]);

                if ((contests.ContainsKey(contest)) 
                    &&(contests[contest]) == password)
                {
                    if (!interns.ContainsKey(username))
                    {
                        interns.Add(username, new Dictionary<string, int>());
                    }
                    if (!interns[username].ContainsKey(contest))
                    {
                        interns[username].Add(contest, points);
                    }
                    else 
                    {
                        if (interns[username][contest] < points)
                        {
                            interns[username][contest] = points;
                        }
                    }
                }

                internData = Console.ReadLine();
            }

            int mostPoints = int.MinValue;
            string bestCandidate = string.Empty;

            foreach (var intern in interns)
            {
                var totalPoints = intern.Value.Sum(x => x.Value);

                if (totalPoints > mostPoints)
                {
                    mostPoints = totalPoints;
                    bestCandidate = intern.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {mostPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var user in interns.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");

                foreach (var contest in user.Value.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
