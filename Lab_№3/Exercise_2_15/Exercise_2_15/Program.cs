namespace Exercise_2_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первого массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите значения превого массива через пробел");
            string[] c1 = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c1[i]);
            }
            Console.WriteLine("Введите размер второго массива");
            int m = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            Console.WriteLine("Введите значения второго массива через пробел");
            string[] c2 = Console.ReadLine().Split();
            for (int i = 0; i < m; i++)
            {
                b[i] = int.Parse(c2[i]);
            }
            Console.WriteLine("Введите индекс числа");
            int k = int.Parse(Console.ReadLine()), y = 0;
            int[] f = new int[n + m];
            if (k <= a.Length)
            {
                for (int i = 0; i < n + m; i++)
                {
                    if (i != k)
                    {
                        f[i] = a[i - y];
                        Console.Write($"{f[i]} ");
                    }
                    else
                    {
                        f[i] = a[i];
                        int j = 0;
                        for (; j < m; j++)
                        {
                            f[i + j + 1] = b[j];
                            Console.Write($"{f[i + j]} ");
                        }
                        Console.Write($"{f[i + j]} ");
                        i += m;
                        y = m;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}