namespace Exercise_1_29
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
            int f_id = 0, f_min = Math.Abs(f[1, 0]);
            for (int i = 0; i < 7; i++)
            {
                if (f_min > Math.Abs(f[1, i]))
                {
                    f_min = Math.Abs(f[1, i]);
                    f_id = i;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = f_id + 1; j < 6; j++)
                {
                    f[i, j] = f[i, j + 1];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}