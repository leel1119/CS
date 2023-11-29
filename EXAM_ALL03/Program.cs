using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_ALL03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][][] irregularArray = new int[3][][];

            irregularArray[0] = new int[][]
                {
                 new int[] {34500,21400,56700},
                 new int[] {23200,41400},
                 new int[] {36800,55600}
                };
            irregularArray[1] = new int[][]
                {
                 new int[] {43500,28700,74700,58900},
                 new int[] {43500,29800}
                };
            irregularArray[2] = new int[][]
                {
                 new int[] {54300,41200,76500},
                 new int[] {33500,22400},
                 new int[] {36800,24200,67900,45200}
                };
            int firstDimensionLength = irregularArray.Length;
            int secondDimensionLength = irregularArray[2].Length;
            int thirdDimensionLength = irregularArray[2][2].Length;

            int minNumber = int.MaxValue; // 初始化最小值為 int 的最大值
            int maxNumber = int.MinValue; // 初始化最大值為 int 的最小值

            for (int i = 0; i < irregularArray.Length; i++)
            {
                int j = 0;
                while (j < irregularArray[i].Length)
                {
                    int k = 0;
                    do
                    {
                        int number = irregularArray[i][j][k];

                        // 找最小值
                        if (number < minNumber)
                        {
                            minNumber = number;
                        }

                        // 找最大值
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                        }

                        k++;
                    } while (k < irregularArray[i][j].Length);

                    j++;
                }
            }

            Console.WriteLine($"幼獅里的Length：{firstDimensionLength}");
            Console.WriteLine($"幼獅里第二鄰的Length：{secondDimensionLength}");
            Console.WriteLine($"幼獅里第二鄰第二戶的Length：{thirdDimensionLength}");
            Console.WriteLine($"最高薪資為：{maxNumber}");
            Console.WriteLine($"最低薪資為：{minNumber}");
            Console.ReadLine();

        }
    }
}
