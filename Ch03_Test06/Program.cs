using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ch03_P140_Virtual_Override_AnotherEX_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geomertry rec = new Rectangle(1.23, 4.56);
            Console.WriteLine($"Area: {rec.area()}");
            //....................................................
            Rectangle rec1 = new Rectangle(1.23, 4.56);
            Console.WriteLine($"Area: {rec1.area()}");
            Console.ReadLine();
        }
    }

    class Geomertry
    {
        //public virtual double area()
        public double area()
        {
            return 0.0;
        }
    }
    class Rectangle : Geomertry
    {
        public double Width {get; set;}
        public double Length {get; set;}
        public Rectangle(double w, double l)
        {
            Width = w;
            Length = l;
        }
        //public override double area()
        public new double area()
        {
            return Width * Length;
        }
    }
}
