using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P18_WriteReadAllByte_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a string in All Bytes Example!";
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            File.WriteAllBytes("file_allBytes_EX.txt", bytes);
            dumpContents(bytes);
            Console.ReadLine();

        }
        static void dumpContents(byte[] data) 
        {
            foreach (byte b in data) 
            {
                Console.WriteLine(b);
            }
        }
    }
}
