using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_P61_CArray_Demo
{
    class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            if (numElements > upper)
            {
                Console.WriteLine("Array is Full, Cannot Insert the Item!!!");
            }
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Clear()
        {
            numElements = 0;
        }
        public void CArrayRandomConfig()
        {
            Clear();
            Random rnd = new Random(123);
            for (int i = 0; i <= upper; i++)
            {
                Insert((int)(rnd.NextDouble() * 100));
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int ASIZE = 10;
            CArray nums = new CArray(ASIZE);
            for (int i = 0; i < ASIZE; i++)
            {
                nums.Insert(i);
            }

            Console.WriteLine("\n\nGenerate A Random Sequence ......\n");

            nums.CArrayRandomConfig();
            nums.DisplayElements();
            Console.ReadLine();
        }
    }
}
