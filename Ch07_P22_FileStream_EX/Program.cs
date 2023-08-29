using System;
using System.IO;
using System.Text;

namespace Ch07_P22_FileStream_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData = new byte[700];
            char[] charData = new char[700];
            try
            {
                FileStream aFile = new FileStream(@"D:\遊戲開發\Programing\CS2023A\CS\Ch07_P22_FileStream_EX\Program.cs", FileMode.Open);
                aFile.Seek(13, SeekOrigin.Begin);
                aFile.Read(byteData, 0, 700);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO Exception Occurs" + ex.ToString());
                return;
            }
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);
            Console.WriteLine(charData);
            Console.ReadLine();
        }
    }
}
