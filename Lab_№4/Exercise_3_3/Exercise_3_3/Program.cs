namespace Exercise_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[5, 5] {
                                    { 4, -23, 32, 55, -6},
                                    { -10, -6, 91, 71, 49},
                                    { 10, 0, 34, 7, -14},
                                    { 10, 5, 4, 333, 14},
                                    { 52, 65 , 99, 44, -9},
                                     };
            int[] d = new int[5 * 2 - 1];
            int sum, z = 0, p = 0;
            for (int t = 0; t < 9; t++)
            {
                sum = 0;
                for (int i = z; i < 5; i++)
                {
                    for (int j = p; j < 5; j++)
                    {
                        sum += f[i, j];
                    }
                }
                d[t] = sum;
                z += 1;
                p += 1;
            }
            for (int i = 0; i < 5 * 2 - 1; i++) Console.Write("{0} ", d[i]);
        }
    }
}