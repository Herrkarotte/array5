using System;

namespace array5
{
    class Program
    {
        static void Main(string[] args)
        {

            const int n = 3;
            Random rnd = new Random();
            int[] Arr1 = new int[n * n];
            int[] Arr2 = new int[n * n];
            int[] Arr3 = new int[n * n];
            for (int i = 0; i != n * n; i++)
            {
                Arr1[i] = i + 1;
                Arr2[i] = i + 1;
            }

            for (int i = 0; i != n; i ++)
            {
                for (int j = 0; j != n; j++)
                {
                    for (int k = 0; k != n; k++)
                    {
                        Arr3[i * n + j] += Arr1[i * n + k] * Arr2[k * n + j];
                    }
                }
            }
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != n; j++)
                {
                    Console.Write($"{Arr3[i * n + j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
