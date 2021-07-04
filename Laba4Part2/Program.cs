using System;
//Дана матрица A порядка n. Расставьте строки матрицы в возрастания убывания количества нулевых элементов.

namespace Laba4ValiaPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] s = new int[4,4] {{1,0,3,0 },{1,3,0,1 },{1,2,3,4 },{0,0,0,0 }};
            int[] sum = new int[4];
            int[] ssum = new int[4]; 
            for (int i = 0; i < 4; i++)
            {
                sum[i] = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (s[i, j] == 0) { sum[i]++; ssum[i]++; }
                }
            }
            Array.Sort(sum);
            
            for (int i = 0; i <4; i++)
            {
               for (int j = 0; j < 4; j++)
                {
                    if (sum[i] == ssum[j])
                        for (int k = 0; k < 4; k++)
                        {
                            Console.Write(s[j, k]);
                        }
                }       Console.WriteLine();
                
            }
        }
    }
}
