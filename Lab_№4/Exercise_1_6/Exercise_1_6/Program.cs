namespace Exercise_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] f = new int[4];  
            int[,] a = new int[4, 7] {
                                    { 1, 2, 3, 4, -4, -3, -2},
                                    { 5, 6, 7, 8, -8, -7000, -6},
                                    { 9, 10, 11, 12, -12, -11, -10},
                                    { -1331, 14, 15, 16, -16, -15, -140}
                                    };
            int minz, min_id;
            for (int i = 0; i < 4; i++)
            {
                minz = a[i, 0];
                min_id = 0;
                for (int j = 0; j < 7; j++)
                {
                     if (minz > a[i, j])
                    {
                        minz = a[i, j];
                        min_id = j;
                    }
                }
                f[i] = min_id;
            }
            Console.WriteLine(String.Join(" ", f));
        }
    }
}