using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream copyStream = new FileStream("../../../CopyFile.png", FileMode.Open))
            {
                using (FileStream pasteStream = new FileStream("../../../PasteFile.png", FileMode.Create))
                {
                    int byteCopy = 0;
                    while (byteCopy != - 1)
                    {
                        byteCopy = copyStream.ReadByte();
                        pasteStream.WriteByte((byte)byteCopy);
                    }
                }
            }
        }
    }
}
