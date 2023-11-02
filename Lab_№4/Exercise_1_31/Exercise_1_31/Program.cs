namespace Exercise_1_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[5, 8] {
                                    { 54, -23, 32, 55, -6, 0, 5, 0 },
                                    { 0, 45 ,-45, -23, 14, 41, 6, 0 },
                                    { 10, 5, 4, -3, 14, 4, 6, 0},
                                    { 52, 65 , 99, 44, -9, 0, 9, 0},
                                    { 100, 56, -3, 97, 44, 3, 7, 0},
                                     };
            int[] v = new int[5] { 1, 2, 3, 4, 5 };
            int f_min = f[4, 0], f_id = 0;
            for (int i = 1; i < 8; i++)
            {
                if (f[4, i] < f_min)
                {
                    f_min = f[4, i];
                    f_id = i;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 7; j > 0; j--)
                {
                    if (j != f_id + 1)
                    {
                        f[i, j] = f[i, j - 1];
                    }
                    else
                    {
                        f[i, j] = v[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}