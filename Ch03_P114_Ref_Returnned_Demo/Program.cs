using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P114_Ref_Returnned_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 11, 2, 35, 40, 42 };
            int itemToFind; 
            foreach (int i in items) Console.Write(i + "\t");      
            Console.WriteLine("\n Please Enter the value to be found : ");
            itemToFind = Convert.ToInt32(Console.ReadLine());
            ref int foundedItem = ref FindItem(itemToFind, items);
            foundedItem = 0;
            foreach (int n in items) Console.Write(n + "\t");
            Console.WriteLine();
            Console.ReadLine();
        }
        static ref int FindItem(int findValue, int[] theArray)
        {
            //int pos = -1;
            int idx = 0;
            for (idx = 0; idx < theArray.Length; idx++) 
            {
                if (findValue == theArray[idx]) break;
            }
            return ref theArray[idx];
        }
    }
}
