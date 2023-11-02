namespace Exercise_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[6, 7] {
                                    { 54, -23, 32, 55, -6, 0, 5 },
                                    { 0, 45 ,-45, -23, 14, 41, 6 },
                                    { 10, 5, 4, -3, 14, 4, 6},
                                    { 52, 65 , 99, 44, -9, 0, 9},
                                    { -100, 56, 36, 97, 44, 3, 7},
                                    { 2, -5, -42, -6, 1, 4, 8},
                                     };
            int f_max = f[0, 0], id1 = 0, id2 = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (f[i, j] > f_max)
                    {
                        f_max = f[i, j];
                        id1 = i;
                        id2 = j;
                    }
                }
            } 
            for (int i = id1; i < 5; i++)
            {
                for (int j = 0; j < 7; j++) f[i, j] = f[i + 1, j];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = id2; j < 6; j++) f[i, j] = f[i, j + 1];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}