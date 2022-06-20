using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\Mosaw\Desktop\test\CSharp2");
            foreach (var sub in myDir.GetFiles())
            {
                Console.WriteLine(sub.Name);
            }
        }
    }
}