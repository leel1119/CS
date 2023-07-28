using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P50_Anonymous_LambdaExpression_EX
{
    internal class Program
    {
        delegate int IntSquareDelegate(int input);
        static void Main(string[] args)
        {
            IntSquareDelegate isd = delegate(int i) { return i * i; }; //匿名函數

            Console.WriteLine($"The Square Result Via Anonymous : {isd(6)}");

            IntSquareDelegate isd2 = (int i) => i * i; // Lambda Expression
            Console.WriteLine($"The Square Result Via Lambda Expression : {isd2(7)}");

            Console.Read();
        }
    }
}
