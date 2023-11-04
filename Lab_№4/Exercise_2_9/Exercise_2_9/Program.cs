namespace Exercise_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[6, 7] {
                                    { 4, -23, 32, 55, -6, 0, 1},
                                    { 10, 0, 34, 7, -14, 304, 2},
                                    { 44, 45 ,3, -23, 14, 41, 3},
                                    { 10, 5, 4, 333, 14, 4, 90},
                                    { 52, 65 , 99, 44, -9, 0, 34},
                                    { -100, 56, 36, 97, 44, 3, 77},
                                     };
            int c;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c = f[i, j];
                    f[i, j] = f[i, 7 - j - 1];
                    f[i, 7 - j - 1] = c;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}