using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P136_Operrator_Overloading_Demo
{
    class Book
    {
        public string Title { get; set; } // 書籍標題
        public int Page { get; set; } // 書籍頁數
        public double Price { get; set; } // 書籍價格

        public static Book operator +(Book first, Book second) // 重載加法運算符的定義
        {
            string name;
            int page = 0;
            double price = 0;

            name = first.Title + " And " + second.Title; // 合併書籍標題
            page = first.Page + second.Page; // 合併書籍頁數
            if (first.Price > second.Price) // 判斷哪本書的價格較高
            {
                price = first.Price + 12.34; // 第一本書的價格加上固定值
            }
            else
            {
                price = second.Price + 12.34; // 第二本書的價格加上固定值
            }
            return new Book(name, page, price); // 回傳合併後的新書籍
        }

        public Book(string title, int page, double price) // 書籍類別的建構子
        {
            Title = title; // 設定書籍標題
            Page = page; // 設定書籍頁數
            Price = price; // 設定書籍價格
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Great Stories", 550, 234.56); // 建立第一本書籍
            Book book2 = new Book("Great Tastes", 350, 543.21); // 建立第二本書籍
            Book book3 = book1 + book2; // 使用加法運算符合併書籍
            Console.WriteLine($"Book3 Title:{book3.Title}, Book3 Page:{book3.Page}, Book3 Price:{book3.Price}"); // 輸出合併後的書籍資訊
            Console.ReadLine();

        }
    }
}
