using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P25_StreamWriter_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                FileStream fs = new FileStream("log.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hello Everyone");
                sw.Write($"It is now {DateTime.Now.ToLongDateString()}");
                sw.Write("\nand All things are looking good.");
                sw.Write("\nMore than that,");
                sw.Write("\nit's true that C# File IO Training are usefull!!!");
                sw.Close();
            } 
            catch(IOException e) 
            {
                Console.WriteLine("IO Exception" + e.ToString());
                return;
            }
            Console.ReadLine();
            
        }
    }
}
