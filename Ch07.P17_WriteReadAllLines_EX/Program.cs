using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07.P17_WriteReadAllLines_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            {
                "This is line 1 of All Lines Examples",
                "This is line 2 of All Lines Examples"
            };
            dumpContents(lines);
            File.WriteAllLines("file_allLines_EX.txt", lines);
            Console.WriteLine("-------------------------------------------");
            string[] received = File.ReadAllLines("file_allLines_EX.txt");
            dumpContents(received);
            Console.ReadLine();
        }
        static void dumpContents(string[] lines)
        {
            foreach (var e in lines)
            {
                Console.WriteLine(e);
            }
        }
    }
}
