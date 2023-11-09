namespace Exercise_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[7, 5] {
                                    { 4, -23, 32, 55, -6},
                                    { -10, -6, 91, 71, 49},
                                    { 10, 0, 34, 7, -14},
                                    { 44, 45 ,3, -23, 14},
                                    { 10, 5, 4, 333, 14},
                                    { 52, 65 , 99, 44, -9},
                                    { -100, -56, -36, -97, 44},
                                     };
            int k, d = 0;
            int[,] r = new int[7, 6];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    r[i, j] = f[i, j];
                }
                r[i, 5] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                k = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (r[i, j] >= 0) k++;
                }
                r[i, 5] = k;
            }
            do 
            { 
                k = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (r[i, 5] < r[i + 1, 5])
                    {
                        k++;
                        for (int j = 0; j < 6; j++)
                        {
                            d = r[i, j];
                            r[i, j] = r[i + 1, j];
                            r[i + 1, j] = d;
                        }
                    }
                } 
            }while (k > 0);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++) Console.Write(r[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}