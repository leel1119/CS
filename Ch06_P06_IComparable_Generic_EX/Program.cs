using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ch06_P06_IComparable_Generic_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3、4、5 中最大的是：{Maximun(3, 4, 5)}");
            Console.WriteLine($"3.3、4.4、5.5 中最大的是：{Maximun(3.3, 4.4, 5.5)}");
            Console.WriteLine($"Leo、Zoe、Tom 中最大的是：{Maximun("Leo", "Zoe", "Tom")}");

            Book a = new Book(100, "書本 A");
            Book b = new Book(200, "書本 B");
            Book c = new Book(300, "書本 C");

            Console.WriteLine($"a、b、c 中最大的是：{Maximun(a, b, c).ToString()}");

            Console.ReadLine();
        }

        // 泛型方法，找出三個元素中的最大值
        static T Maximun<T>(T x, T y, T z) where T : IComparable<T>
        {
            T max = x;
            if (y.CompareTo(max) > 0) max = y;
            if (z.CompareTo(max) > 0) max = z;
            return max;
        }

        // 自定義的 Book 類別實現 IComparable<Book> 接口
        class Book : IComparable<Book>
        {
            public int Page { get; set; }
            public string Name { get; set; }

            public Book(int pg, string name) { Page = pg; Name = name; }

            // 比較兩個 Book 物件
            public int CompareTo(Book other)
            {
                if (Page == other.Page) return 0;
                else if (Page > other.Page) return 1;
                else return -1;
            }

            // 覆寫 ToString 方法，返回書本的名稱
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
