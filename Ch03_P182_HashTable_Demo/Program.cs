using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P182_HashTable_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new Hashtable 
            {
                {1,"Andy"},{2,"Bill"},{3,"Carol"},{4,"David"},{5,"Eric"}
            };

            foreach (var k in hashTable.Keys) 
            {
                Console.WriteLine($"Key: {k}, and Value: {hashTable[k]}");
            }
            Console.ReadLine();
        }
    }
}
