using System.Security.Cryptography;

namespace Exercise_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[6, 6] {
                                    { 4, -23, 32, 55, -6, 0},
                                    { 10, 0, 34, 7, -14, 34},
                                    { 44, 45 ,3, -23, 14, 41},
                                    { 10, 5, 4, 333, 14, 4},
                                    { 52, 65 , 99, 44, -9, 0},
                                    { -100, 56, 36, 97, 44, 3},
                                     };
            int f_max = f[0, 0], f_id = 0;
            for (int i = 1; i < 6; i++)
            {
                if (f[i, i] > f_max)
                {
                    f_max = f[i, i];
                    f_id = i;
                }
            }
            for (int i = 0; i < f_id; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    f[i, j] = 0;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}