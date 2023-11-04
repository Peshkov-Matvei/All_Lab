namespace Exercise_3_2
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
                                    { -100, 56, 36, 97, 44},
                                     };
            for (int i = 0; i < 7; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < 5; j++) f[i, j] = 0;
                }
                else
                {
                    f[i, 0] = 0;
                    f[i, 4] = 0;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}