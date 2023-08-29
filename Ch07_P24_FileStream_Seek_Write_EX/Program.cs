using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P24_FileStream_Seek_Write_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] byteArray;
            char[] charArray;
            try
            {
                FileStream aFile = new FileStream("WriteData.txt", FileMode.Create);
                charArray = "Welcome to YMTC C# Training Course about FileStream Write!!!".ToArray();
                byteArray = Encoding.UTF8.GetBytes(charArray);
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteArray, 0, byteArray.Length);
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurs" + e.ToString());
                return;
            }
            Console.ReadLine();
        }
    }
}
