using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P183_HashTable_Key_Searrch_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hTable = new Hashtable
            {
                {1,"Andy"},
                {2,"Bill" },
                {3,"Carol" },
                {4,"David" },
                {5,"Eric" }
            };

            hTable.Add(6, "Frank");
            Console.WriteLine("//---------------Show All Elements in hTable");
            ShowElement(hTable);
            

            int i=0;
            foreach (var key in hTable.Keys)
            {
                if (hTable[key].Equals("Carol"))
                { 
                    i = (int)key;
                    break;
                }
            }

            hTable.Remove(i);
            ShowElement(hTable);

            if (hTable.Contains(5))
            {
                hTable.Remove(5);
                ShowElement(hTable);
            }

            if (hTable.ContainsKey(2))
            {
                hTable.Remove(2);
                ShowElement(hTable);
            }

            hTable.Clear();
            foreach (var key in hTable.Keys)
            {
                Console.WriteLine($"key: {key}, value:{hTable[key]}");
            }

            Console.WriteLine("Empty hTable");
            Console.ReadLine();
        }

        static void ShowElement(Hashtable h)
        {
            foreach (var key in h.Keys)
            {
                Console.WriteLine($"key: {key}, value:{h[key]}");
            }
            Console.WriteLine();
        }
            
    }
}
