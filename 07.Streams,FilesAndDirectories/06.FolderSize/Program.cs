using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesInFolder = Directory.GetFiles("../../../TestFolder");
            double bytes = 0;
            foreach (string item in filesInFolder)
            {
                FileInfo fileInfo = new FileInfo(item);
                bytes += fileInfo.Length;
            }
            double kilobytes = bytes / 1024;
            double megabytes = kilobytes / 1024;
            File.WriteAllText("../../../Output.txt", megabytes.ToString());
        }
    }
}
