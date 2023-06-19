using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P135_Object_Init_CTOR_FNBLK_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BOX box1 = new BOX() { Height = 11, Depth = 9};
            BOX box2 = new BOX() { Width = 8};
            BOX box3 = new BOX() { Depth = 7 };
            Console.WriteLine($"box1 Height:{box1.Height}, box1 Width:{box1.Width}, box1 depth:{box1.Depth}");
            Console.WriteLine($"box1 Height:{box2.Height}, box1 Width:{box2.Width}, box1 depth:{box2.Depth}");
            Console.WriteLine($"box1 Height:{box3.Height}, box1 Width:{box3.Width}, box1 depth:{box3.Depth}");
            Console.ReadLine();
        }
    }

    class BOX
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        public BOX() 
        {
            Width = 2; Height = 1; Depth = 3;
        }
    }
}
