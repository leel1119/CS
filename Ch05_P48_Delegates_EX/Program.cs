using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 在這個範例中，我們首先定義了一個委託類型 ShowStringDelegate，該委託類型用於指向返回值為 void，參數為 string 的方法。
 * 然後在 Main 方法中，我們創建了兩個委託實例 sd 和 sd2，並分別指向 ShowString 方法。我們可以通過委託調用 ShowString 
 * 方法並輸出相應的訊息。
 * 此外，我們還定義了一個 PassDelegate 方法，它接受一個 ShowStringDelegate 委託類型的參數 del，並在該方法內部使用該委託
 * 類型來調用方法。我們可以通過 PassDelegate 方法來將委託作為參數傳遞，並在方法內部使用委託來執行相應的操作。這使得程式碼
 * 更加靈活和可重用。
 */
namespace Ch05_P48_Delegates_EX
{
    // 定義委託類型，該委託類型用於指向返回值為 void，參數為 string 的方法
    delegate void ShowStringDelegate(string msg);

    internal class Program
    {
        static void Main(string[] args)
        {
            // 建立委託實例 sd，並指向 ShowString 方法
            ShowStringDelegate sd = ShowString;

            // 通過委託調用 ShowString 方法
            sd("歡迎來到YMTC");

            // 也可以使用 new 關鍵字來建立委託實例，並指向 ShowString 方法
            ShowStringDelegate sd2 = new ShowStringDelegate(ShowString);
            sd2("See You Again, YMTC!");

            // 將委託作為參數傳遞給 PassDelegate 方法，並在該方法內部調用委託
            PassDelegate(sd, "第一種用法！");
            PassDelegate(sd2, "第二種用法！");

            Console.ReadLine();
        }

        // 這是委託所指向的方法，參數為 string，用於顯示傳入的字串
        static void ShowString(string str)
        {
            Console.WriteLine(str);
        }

        // PassDelegate 方法接受一個 ShowStringDelegate 委託類型的參數 del，並使用該委託類型來調用方法
        static void PassDelegate(ShowStringDelegate del, string str)
        {
            del(str);
        }
    }
}
