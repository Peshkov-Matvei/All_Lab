namespace Exercise_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[7, 5] {
                                    { 4, -23, 32, 55, 0},
                                    { -10, -6, 91, 71, 49},
                                    { 10, 0, 34, 7, -14},
                                    { 44, 45 ,3, -23, 14},
                                    { 10, 5, 4, 333, 14},
                                    { 52, 65 , 99, 44, -9},
                                    { -100, -56, -36, 0, 44},
                                     };
            int k, d, t = 0;
            int[] r = new int[7];
            for (int i = 0; i < 7; i++)
            {
                k = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (f[i, j] == 0) k++;
                }
                if (k != 0) t++;
                r[i] = k;
            }
            do
            {
                k = 0;
                for (int i = 0; i < 6; i++)
                {
                    if ((r[i] != 0) && (r[i + 1] == 0))
                    {
                        k++;
                        for (int j = 0; j < 5; j++)
                        {
                            d = f[i, j];
                            f[i, j] = f[i + 1, j];
                            f[i + 1, j] = d;
                        }
                        d = r[i];
                        r[i] = r[i + 1];
                        r[i + 1] = d;
                    }
                }
            } while (k > 0);
            for (int i = 0; i < 7 - t; i++)
            {
                for (int j = 0; j < 5; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}