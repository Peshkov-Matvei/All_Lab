namespace Exercise_3_2
{
    internal class Program
    {
        delegate int[,] fi(int[,] s, int i);
        static int[,] Chet(int[,] s, int i)
        {
            int k, r;
            do
            {
                k = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (s[i, j] > s[i, j + 1])
                    {
                        r = s[i, j];
                        s[i, j] = s[i, j + 1];
                        s[i, j + 1] = r;
                        k++;
                    }
                }
            } while (k > 0);
            return s;
        }
        static int[,] NeChet(int[,] s, int i)
        {
            int k, r;
            do
            {
                k = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (s[i, j] < s[i, j + 1])
                    {
                        r = s[i, j];
                        s[i, j] = s[i, j + 1];
                        s[i, j + 1] = r;
                        k++;
                    }
                }
            } while (k > 0);
            return s;
        }
        static int[,] P(int[,] s, int[,] f, int i)
        {
            int[,] t = s;
            for (int j = 6; j < 6; j++)
            {
                f[i, j] = t[i, j];
            }
            return f;
        }
        static void Main(string[] args)
        {
            const int n = 6;
            int[] t = new int[n];
            int[,] f = new int[n, n] {
                                    { -10, -6, 92, 70, 50, 45},
                                    { 10, 500, 34, 70, -14, 1},
                                    { 44, 48 ,6, 558, 14, 20},
                                    { 10, 6, 4, -4, 14, -22},
                                    { 52, 564 , 98, 544, -10, 81},
                                    { -100,  -56, -36, 590, 44, -3},
                                     };
            fi chet = Chet;
            fi nechet = NeChet;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 6; j++) t[j] = f[i, j];
                if (i % 2 == 0)
                {
                    f = P(chet(f, i), f, i);
                }
                else
                {
                    f = P(nechet(f, i), f, i);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++) Console.Write(f[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}