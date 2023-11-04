namespace Exercise_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[7, 6] {
                                    { 4, -23, 32, 55, -6, 0},
                                    { -10, -6, 91, 71, 49, 0},
                                    { 10, 0, 34, 7, -14, 0},
                                    { 44, 45 ,3, -23, 14, 0},
                                    { 10, 5, 4, 333, 14, 0},
                                    { 52, 65 , 99, 44, -9, 0},
                                    { -100, 56, 36, 97, 44, 0},
                                     };
            int f_min, k, t;
            for (int i = 0; i < 7; i++)
            {
                f_min = f[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    f_min = Math.Min(f_min, f[i, j]);
                }
                f[i, 5] = f_min;
            }
            do
            {
                k = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (f[i, 5] < f[i + 1, 5])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            t = f[i, j];
                            f[i, j] = f[i + 1, j];
                            f[i + 1, j] = t;
                        }
                        k++;
                    }
                }
            } while (k > 0);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}  