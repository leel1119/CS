using System;

class Program
{
    static void Main()
    {
        PrintPattern(5);
    }

    static void PrintPattern(int height)
    {
        int row = 0;
        while(row <= 4)
        {
            int col = 0;
            while (col <= 8)
            {
                if (Math.Abs(col - 4) <= (4 - row)) Console.Write("*");
                else Console.Write(" ");
                col++;
            }
            Console.WriteLine();
            row++;
        }
        row = 0;
        while(row <= 3) 
        {
            int col = 0;
            while (col <= 8) 
            {
                if (Math.Abs(col - 4) <= (row + 1)) Console.Write("*");
                else Console.Write(" ");
                col++;
            }
            Console.WriteLine();
            row++;
        }
        Console.ReadLine();
    }
}
