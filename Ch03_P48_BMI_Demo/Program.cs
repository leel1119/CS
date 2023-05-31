using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P48_BMI_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.WriteLine("Please input the Weight in KG:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the Height in M:");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = weight / (height * height);
            Console.WriteLine("The Calculated BMI is :"+ bmi);
            Console.ReadLine();
        }
    }
}
