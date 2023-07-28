using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P49_MultiCastDelegate_EX
{
    // 定義委託類型 GreeHandler，該委託類型用於指向返回值為 void，參數為 string 的方法
    delegate void GreeHandler(string s);

    internal class Program
    {
        static void Main(string[] args)
        {
            GreeHandler gh = Hello; // 建立委託實例 gh，並指向 Hello 方法
            dispatchDelegateMSG(gh, "Andy"); // 通過委託調用 Hello 方法

            gh = GoodBye; // 改變委託實例 gh 的指向，現在指向 GoodBye 方法
            dispatchDelegateMSG(gh, "Bill"); // 通過委託調用 GoodBye 方法

            gh = Hello;
            gh += GoodBye;  //串接方式
            dispatchDelegateMSG(gh, "Andy");

            Console.ReadLine();
        }

        // dispatchDelegateMSG 方法接受一個 GreeHandler 委託類型的參數 gh，並一個 string 參數 msg
        // 在該方法內部，通過委託 gh 調用相應的方法並輸出訊息
        static void dispatchDelegateMSG(GreeHandler gh, string msg)
        {
            Console.WriteLine("The Greeting is : ");
            gh(msg);
        }

        // 這是委託所指向的方法，參數為 string，用於顯示 Hello 訊息
        static void Hello(string msg)
        {
            Console.WriteLine($"Hello {msg}");
        }

        // 這是委託所指向的方法，參數為 string，用於顯示 GoodBye 訊息
        static void GoodBye(string msg)
        {
            Console.WriteLine($"Goodbye {msg}");
        }
    }
}
