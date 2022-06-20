using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = File.ReadAllText(@"C:\Users\Mosaw\Desktop\test\CSharp2\FileDirOpdracht\Text.txt");
            string[] lines = File.ReadAllLines(@"C:\Users\Mosaw\Desktop\test\CSharp2\FileDirOpdracht\Text.txt");
            Console.WriteLine(lines);
        }
    }
}
