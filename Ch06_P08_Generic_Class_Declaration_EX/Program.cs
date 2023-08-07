using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P08_Generic_Class_Declaration_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point <int> a = new Point<int> (1,2);
            a.showInternalState();
            Console.ReadLine();
        }
    }
    class Point<T>
    { 
        public T x,y;
        public Point(T x, T y) 
        {
            this.y = y;
            this.x = x;
        }
        public void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}");
        }
    }
}
