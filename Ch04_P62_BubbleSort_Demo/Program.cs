using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_P62_BubbleSort_Demo
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
        public void BubbleSort()
        {
            int temp=0;

            for (int outer = numElements-1; outer >=1 ; outer--) 
            {
                for (int inner = 0; inner <= outer-1; inner++)
                {
                    if (arr[inner] > arr[inner+1])
                    { 
                        temp = arr[inner];
                        arr[inner] = arr[inner+1];
                        arr[inner+1] = temp;
                    }
                }
            }
        }
        public void insertSort()
        {
            int temp = 0;
            int inner;
            for (int outer = 1; outer < numElements; outer++)
            {
                temp = arr[outer];
                for (inner = outer; inner > 0 && arr[inner - 1] >= temp; inner--)
                {
                    arr[inner] = arr[inner - 1];
                        
                }
                arr[inner] = temp;
            }
        }
        public void SelectSort()
        {
            int temp = 0;
            int min;
            for (int outer = 0; outer < numElements; outer ++)
            {
                min = outer;
                for (int inner = outer + 1; inner < numElements; inner++)
                {
                    if (arr[inner] < arr[min])
                    {
                        min = inner;
                    }
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
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
            Random rnd = new Random();
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
            nums.CArrayRandomConfig();
            nums.BubbleSort();
            nums.DisplayElements();
            Console.WriteLine();
            nums.SelectSort();
            nums.DisplayElements();
            Console.WriteLine();
            nums.insertSort();
            nums.DisplayElements();
            Console.ReadLine();
        }
    }
}
