namespace Exercise_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4, t;
            int[,] f = new int[4, 4] {
                                    { 1, 2, 3, 4},
                                    { 5, 6, 7, 8},
                                    { 9, 10, 11, 12},
                                    { 13, 14, 15, 16}
                                    };
            if (n % 2 != 0) t = (n + 1) / 2 - 1;
            else t = n / 2;
            for (int i = t; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    f[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}