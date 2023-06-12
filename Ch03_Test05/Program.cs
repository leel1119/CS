using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(1.23, 3.45);
            Rectangle rec2 = new Rectangle(3.21, 5.43);
            Console.WriteLine($"rec1 width is : {rec1.Width}, and Length is : {rec1.Length}, area is :{rec1.Area}");
            Console.WriteLine($"rec2 width is : {rec2.Width}, and Length is : {rec2.Length}, area is :{rec2.Area}");
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area { get; set; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
            Area = Width * Length / 2;
        }
    }

}
