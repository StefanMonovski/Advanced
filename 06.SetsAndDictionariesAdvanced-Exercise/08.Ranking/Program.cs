using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, string> contests = new Dictionary<string, string>();
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestData = input.Split(":");
                contests.Add(contestData[0], contestData[1]);
            }
            Dictionary<string, Dictionary<string, int>> usersPoints = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] userData = input.Split("=>");
                string contest = userData[0];
                string password = userData[1];
                string user = userData[2];
                int points = int.Parse(userData[3]);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (usersPoints.ContainsKey(user))
                    {
                        if (usersPoints[user].ContainsKey(contest))
                        {
                            if (usersPoints[user][contest] < points)
                            {
                                usersPoints[user][contest] = points;
                            }
                        }
                        else
                        {
                            usersPoints[user].Add(contest, points);
                        }
                    }
                    else
                    {
                        usersPoints.Add(user, new Dictionary<string, int>());
                        usersPoints[user].Add(contest, points);
                    }
                }
            }
            int bestPoints = int.MinValue;
            string bestUser = "";
            foreach (var item in usersPoints)
            {
                int totalPoints = 0;
                foreach (var points in item.Value)
                {
                    totalPoints += points.Value;
                    if (bestPoints < totalPoints)
                    {
                        bestPoints = totalPoints;
                        bestUser = item.Key;
                    }
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in usersPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var points in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
