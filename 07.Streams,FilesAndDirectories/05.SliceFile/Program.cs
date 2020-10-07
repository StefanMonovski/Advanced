using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int filesCount = 4;
            using (var streamReadFile = new FileStream("../../../Input.txt", FileMode.Open))
            {
                long fileSize = streamReadFile.Length / filesCount;
                for (int i = 0; i < filesCount; i++)
                { 
                    using (var streamCreateFile = new FileStream($"../../../Part-{i + 1}.txt", FileMode.Create))
                    {
                        long currentFileSize = 0;
                        byte[] buffer = new byte[1];
                        while (currentFileSize < fileSize)
                        {
                            streamReadFile.Read(buffer, 0, buffer.Length);
                            streamCreateFile.Write(buffer, 0, buffer.Length);
                            currentFileSize += buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
