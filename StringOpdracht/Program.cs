using System.IO;
using System;

namespace StringOpdracht
{
    class Program
    {

        static void Main(string[] args)
        {
            string file = @"C:\MA\2021-2022\P4\GDCSharp2\CSharp2opdrachten2\txt\stringsplit.txt";

            string text = File.ReadAllText(file);
            string[] value = text.Split(':');
            string[] nummers = (value[1].Split(','));
        }
    }
}
