namespace Exercise_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[5, 7] {
                                    { 54, -23, 32, 55, -6, 0, 5 },
                                    { 44, 45 ,3, -23, 14, 41, 6 },
                                    { 10, 5, 4, -3, 14, 4, 6},
                                    { 52, 65 , 99, 44, -9, 0, 9},
                                    { -100, 56, 36, 97, 44, 3, 7},
                                     };
            int k, d = 0;
            do
            {
                k = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j += 2)
                    {
                        if (f[i, j] < f[i, j + 2])
                        {
                            d = f[i, j];
                            f[i, j] = f[i, j + 2];
                            f[i, j + 2] = d;
                            k++;
                        }
                    }
                    for (int j = 1; j < 4; j += 2)
                    {
                        if (f[i, j] > f[i, j + 2])
                        {
                            d = f[i, j];
                            f[i, j] = f[i, j + 2];
                            f[i, j + 2] = d;
                            k++;
                        }
                    }
                }
            } while (k > 0);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}