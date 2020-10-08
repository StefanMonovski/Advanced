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
            string[] filesInFolder = Directory.GetFiles("../../../TestFolder");
            Dictionary<string, Dictionary<string, double>> filesInfo = new Dictionary<string, Dictionary<string, double>>();
            foreach (var item in filesInFolder)
            {
                FileInfo currentFileInfo = new FileInfo(item);
                if (filesInfo.ContainsKey(currentFileInfo.Extension))
                {
                    filesInfo[currentFileInfo.Extension].Add(currentFileInfo.Name, ((double)currentFileInfo.Length / 1024));
                }
                else
                {
                    filesInfo.Add(currentFileInfo.Extension, new Dictionary<string, double>());
                    filesInfo[currentFileInfo.Extension].Add(currentFileInfo.Name, ((double)currentFileInfo.Length / 1024));
                }
            }
            using (StreamWriter writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.txt")))
            {
                foreach (var item in filesInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value:f3}kb");
                    }
                }
            }
        }
    }
}
