namespace Exercise_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] f = new int[n, n] {
                                    { 14, -23, 32, 55, -6},
                                    { 0, 145 ,-45, -23, 14},
                                    { 10, 5, 4, -3, 14},
                                    { 520, 65 , 9, 44, -9},
                                    { -100, 56, 36, 97, 44},
                                     };
            int fmax = f[0, 0], max_id1 = 0, fmin = f[0, 0], min_id1 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    if (f[i, j] < fmin)
                    {
                        fmin = f[i, j];
                        min_id1 = j;
                    }
                }
                for (int j = i; j >= 0; j--)
                {
                    if (f[i, j] > fmax)
                    {
                        fmax = f[i, j];
                        max_id1 = j;
                    }
                }
            }
            D(f, min_id1, n, n, out f);
            D(f, max_id1, n, n - 1, out f);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 2; j++) Console.Write("{0} ", f[i, j]);
                Console.WriteLine();
            }
            static void D(int[,] f, int id1, int n, int m, out int[,] c)
            {
                int k;
                c = new int[n, m - 1];
                for (int i = 0; i < n; i++) 
                {
                    for (int j = id1; j < m - 1; j++)
                    {
                        k = f[i, j];
                        f[i, j] = f[i, j + 1];
                        f[i, j + 1] = k;
                    }
                }
                for (int i = 0; i < n; i++) 
                {
                    for (int j = 0; j < m - 1; j++) c[i, j] = f[i, j];
                 }
            }
        }
    }
}