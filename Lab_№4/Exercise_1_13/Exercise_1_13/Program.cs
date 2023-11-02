namespace Exercise_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[5, 5] {
                                    { 14, -23, 32, 55, -6},
                                    { 0, 145 ,-45, -23, 14},
                                    { 10, 5, 4, -3, 14},
                                    { 52, 65 , 99, 44, -9},
                                    { -100, 56, 36, 97, 44},
                                     };
            int f_max = f[0, 0], f_id = 0, test = 0;
            for (int i = 1; i < 5; i++)
            {
               if (f[i, i] > f_max)
               {
                   f_max = f[i, i];
                    f_id = i;
               }
            }
            for (int i = 0; i < 5; i++)
            {
                test = f[i, f_id];
                f[i, f_id] = f[i, 3];
                f[i, 3] = test;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}