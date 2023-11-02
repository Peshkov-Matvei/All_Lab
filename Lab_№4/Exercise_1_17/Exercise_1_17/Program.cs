namespace Exercise_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[4, 5] {
                                    { 14, -23, 32, 55, -6},
                                    { 0, 145 ,-45, -23, 14},
                                    { 10, 5, 4, -3, 14},
                                    { 52, 65 , 99, 44, -9},
                                     };
            int f_max = f[0, 0], f_id = 0, f_min, test = 0;
            for (int i = 0; i < 4; i++)
            {
                f_min = f[i, 0];
                for (int j = 1; j < 5; j ++)
                {
                    if (f[i, j] < f_min)
                    {
                        f_min = f[i, j];
                        f_id = j;
                    }
                }
                for (int j = 4; j > 0; j--)
                {
                    if (f_id == j)
                    {
                        test = f[i, j - 1];
                        f[i, j - 1] = f[i, j];
                        f[i, j] = test;
                        f_id--;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}