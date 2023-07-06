using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P187_SortedList_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sList = new SortedList
            {
                {2,"Bill" },
                {1,"Andy"},
                {3,"Carol" },
                {4,"David" },
                {5,"Eric" }
            };

            sList.Add(6, "Frank");
            Console.WriteLine("//---------------Show All Elements in hTable");
            ShowElement(sList);


            int i = 0;
            foreach (var key in sList.Keys)
            {
                if (sList[key].Equals("Carol"))
                {
                    i = (int)key;
                    break;
                }
            }

            sList.Remove(i);
            ShowElement(sList);

            if (sList.Contains(5))
            {
                sList.Remove(5);
                ShowElement(sList);
            }

            if (sList.ContainsKey(2))
            {
                sList.Remove(2);
                ShowElement(sList);
            }

            sList.Clear();
            foreach (var key in sList.Keys)
            {
                Console.WriteLine($"key: {key}, value:{sList[key]}");
            }

            Console.WriteLine("Empty sList");
            Console.ReadLine();
        }

        static void ShowElement(SortedList s)
        {
            foreach (var key in s.Keys)
            {
                Console.WriteLine($"key: {key}, value:{s[key]}");
            }
            Console.WriteLine();
        }

    }
}
