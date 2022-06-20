using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string text = System.IO.File.ReadAllText(@"C:\MA\2021-2022\P4\GDCSharp2\CSharp2opdrachten2\txt\lol.txt");

            
            System.Console.WriteLine("Dit is wat er in lol.txt staat = {0}", text);

         
            string[] lines = System.IO.File.ReadAllLines(@"C:\MA\2021-2022\P4\GDCSharp2\CSharp2opdrachten2\txt\lol1.txt");

            
            System.Console.WriteLine("Dit staat er in lol1.txt = ");
            foreach (string line in lines)
            {
                
                Console.WriteLine("\t" + line);
            }

            
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}