using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ch03_P127_Private_Auxiliary_Function_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 創建一個 Carpet 物件
            Carpet carpet = new Carpet();

            // 設定地毯的寬度為 38
            carpet.Width = 38;

            // 設定地毯的長度為 64
            carpet.Length = 64;

            // 顯示地毯的寬度、長度和面積
            Console.WriteLine($"Width: {carpet.Width}, and Length: {carpet.Length}, and area: {carpet.Area}");
            Console.ReadLine();
        }
    }

    // Carpet 類別代表一塊地毯
    class Carpet
    {
        private int length;  // 地毯的長度
        private int width;   // 地毯的寬度
        //private int area;    // 地毯的面積

        // 地毯的長度屬性
        public int Length
        {
            get { return length; }
            set
            {
                length = value;
                Area = value * width;  // 更新地毯的面積
            }
        }

        // 地毯的寬度屬性
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                Area = value * length;  // 更新地毯的面積
            }
        }

        // 地毯的面積屬性
        public int Area
        {
            get; set;
           // get { return area; }
        }
    }
}
