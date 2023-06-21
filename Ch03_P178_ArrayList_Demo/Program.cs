using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P178_ArrayList_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 30;
            var aList = new ArrayList();
            var randNumber = new Random(count); //seed = count
            for (int i = 0; i < count; i++) aList.Add(randNumber.Next(count));
            showElement(aList);
            Console.WriteLine($"Capacity: {aList.Capacity}, Count: {aList.Count}");

            for (int i = 0; i < count; i++) aList.Add(randNumber.Next(count+12));
            showElement(aList);
            Console.WriteLine($"Capacity: {aList.Capacity}, Count: {aList.Count}");

            Console.ReadLine();
        }
        static void showElement(ArrayList list)
        { 
            foreach (var e in list) 
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }
}
