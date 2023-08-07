using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P12_Generic_Interface_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Store(12);
            box.showInternalState();

            GenericBox<String> boxstr = new GenericBox<String>();
            boxstr.Store("C# Generic Box");
            boxstr.showInternalState();

            Console.ReadLine();
        }
    }
    interface IGenericColection<T>
    {
        void Store(T t);
        void showInternalState();
    }
    class Box : IGenericColection<int>
    {
        public int myBox;
        public void Store(int i) { myBox = i; }
        public void showInternalState() 
        {
            Console.WriteLine($"The Box myBox is:{myBox}");
        }
    }
    class GenericBox<T> : IGenericColection<T>
    {
        public T myBox;
        public void Store(T t) { myBox = t; }
        public void showInternalState()
        {
            Console.WriteLine($"The Box myBox is:{myBox}");
        }
    }

}
