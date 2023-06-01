using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P87_RaggedArray_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] a = new string[2][];
            a[0] = new string[2]; a[0][0] = "abc"; a[0][1] = "def";
            a[1] = new string[3]; a[1][0] = "mno"; a[1][1] = "pqr"; a[1][2] = "stu";

            Console.WriteLine("Ragged Array a[0] " + a[0][0] +" " + a[0][1]);
            Console.WriteLine("Ragged Array a[1] " + a[1][0] +" " + a[1][1] + " " + a[1][2]);
            Console.ReadLine();
        }
    }
}
