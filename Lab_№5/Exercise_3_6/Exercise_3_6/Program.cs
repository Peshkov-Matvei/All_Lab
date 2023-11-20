namespace Exercise_3_6
{
    internal class Program
    {
        delegate int maxim(int[,] f);
        static int Max_diag(int[,] f)
        {
            int m = f[0, 0], d = 0;
            for (int i = 1; i < 6; i++) 
            { 
                if (f[i, i] > m)
                {
                    d = i;
                    m = f[i, i];
                }
            }
            return d;
        }
        static int Max_first(int[,] f)
        {
            int m = f[0, 0], d = 0;
            for (int i = 1; i < 6; i++)
            {
                if (f[0, i] > m)
                {
                    d = i;
                    m = f[i, i];
                }
            }
            return d;
        }
        static int[,] R(int d, int s, int[,] f)
        {
            int k;
            for (int i = 0; i < 6; i++)
            {
                k = f[i, d];
                f[i, d] = f[i, s];
                f[i, s] = k;
            }
            return f;
        }
        static void Main(string[] args)
        {
            const int n = 6;
            int[,] f = new int[n, n] {
                                    { -10, 10000, 92, 70, 50, 45},
                                    { 10, 500, 34, 70, -14, 1},
                                    { 44, 48 ,6, 558, 14, 20},
                                    { 10, 6, 4, -4, 14, -22},
                                    { 52, 564 , 98, 544, 500000, 81},
                                    { -100,  -56, -36, 590, 44, -3},
                                     };
            maxim max_diag = Max_diag;
            maxim max_first = Max_first;
            f = R(max_diag(f), max_first(f), f);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}