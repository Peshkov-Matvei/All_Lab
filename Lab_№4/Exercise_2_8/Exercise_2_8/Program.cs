namespace Exercise_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[6, 6] {
                                    { 4, -23, 32, 55, -6, 0},
                                    { 10, 0, 34, 7, -14, 304},
                                    { 44, 45 ,3, -23, 14, 41},
                                    { 10, 5, 4, 333, 14, 4},
                                    { 52, 65 , 99, 44, -9, 0},
                                    { -100, 56, 36, 97, 44, 3},
                                     };
            int max1, id1, max2, id2, c;
            for (int i = 0; i < 6; i+=2)
            {
                max1 = f[i, 0];
                max2 = f[i + 1, 0];
                id1 = 0;
                id2 = 0;
                for (int j = 1; j < 6; j++)
                {
                    if (f[i, j] > max1)
                    {
                        max1 = f[i, j];
                        id1 = j;
                    }
                    if (f[i + 1, j] > max2)
                    {
                        max2 = f[i + 1, j];
                        id2 = j;
                    }
                }
                c = f[i, id1];
                f[i, id1] = f[i + 1, id2];
                f[i + 1, id2] = c;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}