using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P59_Boxing_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object obj = i;
            i = 456;
            
            try 
            {
                int j = (int)obj; //(short)
                Console.WriteLine("Unboxing");
            }
            catch (InvalidCastException ex) 
            {
                Console.WriteLine($"Exception e: {ex.Message}");
            }
            Console.WriteLine($"i:{i}, obj: {obj}");
            Console.Read();
        }
    }
}
