using System;

namespace Exercise_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            int[] f = new int[n - 1];
            Console.WriteLine("Введите значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            int smin = 2147483547;
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(c[i]);
                if (s[i] >= 0)
                {
                    smin = Math.Min(smin, s[i]);
                }
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] != smin)
                {
                    f[j] = s[i];
                    Console.Write("{0} ", f[j++]);
                }
            }
        }
    }
}