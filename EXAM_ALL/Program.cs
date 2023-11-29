using System;

class Program
{
    static void Main()
    {
        PrintPattern(5);
    }

    static void PrintPattern(int height)
    {
        int i = 0;
        while (i < height)
        {
            int j = 0;

            while (j < i)
            {
                Console.Write("  ");
                j++;
            }

            j = 0;
            while (j < 2 * (height - i) - 1)
            {
                Console.Write("*");
                j++;
            }

            Console.WriteLine();
            i++;
        }

        i = height - 2;
        while (i >= 0)
        {
            int j = 0;


            while (j < i)
            {
                Console.Write("  ");
                j++;
            }

            j = 0;
            while (j < 2 * (height - i) - 1)
            {
                Console.Write("*");
                j++;
            }

            Console.WriteLine();
            i--;
        }
        Console.ReadLine();
    }
}
