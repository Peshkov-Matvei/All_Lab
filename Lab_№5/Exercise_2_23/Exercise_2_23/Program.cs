namespace Exercise_2_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] f1 = new int[n, n] {
                                    { 14, -22, 32, 56, -6},
                                    { 0, 144 ,-46, 552, 14},
                                    { 10, 6, 4, -4, 14},
                                    { 520, 66 , 8, 44, 555},
                                    { -100, 56, 500, 530, 44},
                                     };
            int[,] f2 = new int[n, n] {
                                    { -10, -6, 92, 70, 50},
                                    { 10, 500, 34, 70, -14},
                                    { 44, 48 ,6, 558, 14},
                                    { 52, 564 , 98, 544, -10},
                                    { -100,  -56, -36, 590, 44},
                                     };
            D(f1, n, out f1);
            D(f2, n, out f2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", f1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", f2[i, j]);
                }
                Console.WriteLine();
            }
            static void D(int[,] f, int n, out int[,] c)
            {
                c = new int[n, n]; 
                int min, min_id;
                int[] t = new int[15];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        min = t[0];
                        min_id = 0;
                        for (int k = 3; k < 15; k += 3)
                        {
                            if (t[k] < min)
                            {
                                min = t[k];
                                min_id = k;
                            }
                        }
                        if (f[i, j] > min)
                        {
                            t[min_id] = f[i, j];
                            t[min_id + 1] = i;
                            t[min_id + 2] = j;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                            f[i, j] = f[i, j] / 2;
                    }
                }
                for (int i = 1; i < 15; i+=3)
                {
                    f[t[i], t[i + 1]] *= 4;
                }
                c = f;
            }
        }
    }
}