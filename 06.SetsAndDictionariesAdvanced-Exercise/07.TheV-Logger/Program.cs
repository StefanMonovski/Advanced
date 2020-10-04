using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, VloggerData> vloggers = new Dictionary<string, VloggerData>();
            while ((input = Console.ReadLine()) != "Statistics")
            {
                List<string> inputData = input.Split().ToList();
                if (inputData[1] == "joined")
                {
                    string vlogger = inputData[0];
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new VloggerData(new HashSet<string>(), new HashSet<string>()));
                    }
                }
                else if (inputData[1] == "followed")
                {
                    string firstVlogger = inputData[0];
                    string secondVlogger = inputData[2];
                    if (vloggers.ContainsKey(firstVlogger) && vloggers.ContainsKey(secondVlogger))
                    {
                        if (firstVlogger != secondVlogger && !vloggers[firstVlogger].Followings.Contains(secondVlogger))
                        {
                            vloggers[firstVlogger].Followings.Add(secondVlogger);
                            vloggers[secondVlogger].Followers.Add(firstVlogger);
                        }
                    }
                }
            }
            var orderedVloggers = vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Followings.Count);
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int position = 1;
            foreach (var item in orderedVloggers)
            {
                Console.WriteLine($"{position}. {item.Key} : {item.Value.Followers.Count} followers, {item.Value.Followings.Count} following");
                if (position == 1)
                {
                    foreach (string follower in item.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                position++;
            }
        }
    }

    public class VloggerData
    {
         public HashSet<string> Followers;
        public HashSet<string> Followings;

        public VloggerData(HashSet<string> followers, HashSet<string> followings)
        {
            Followers = followers;
            Followings = followings;
        }
    }
}
