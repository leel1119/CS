using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P27_GZipStream_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to be repeated 100 times later:");
            string sourceString = Console.ReadLine();
            StringBuilder sourceStringMultiplier = new StringBuilder(100 * sourceString.Length);
            for (int i = 0; i < 100; i++) sourceStringMultiplier.Append(sourceString);
            sourceString = sourceStringMultiplier.ToString();
            Console.WriteLine("sourceString length: " + sourceString.Length + "bytes long");
            Console.ReadLine();
        }
        static void SaveCompressedFile(string fileName, string dataSource)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            GZipStream compressionStream = new GZipStream(fs, CompressionMode.Compress);
            StreamWriter sw = new StreamWriter(compressionStream);
            sw.Write(dataSource);
            sw.Close();
        }
    }
}
