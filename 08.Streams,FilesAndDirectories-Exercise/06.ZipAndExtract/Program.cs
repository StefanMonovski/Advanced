using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../ZipFolder", "ZipAndExtractFile.zip");
            ZipFile.ExtractToDirectory("ZipAndExtractFile.zip", "../../../ExtractFolder");
        }
    }
}
