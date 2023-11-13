namespace Exercise_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7] { 1, 2, 3, 83, 4, 5, 6 };
            int[] b = new int[8] { 1, 2, 3, 83, 4, 5, 6, 7 };
            int[] a1;
            int[] b1;
            D(a, out a1);
            D(b, out b1);
            int[] c = new int[a1.Length + b1.Length];
            int n = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                c[n++] = a1[i];
            }
            for (int i = 0; i < b1.Length; i++)
            {
                c[n++] = b1[i];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            static void D(int[] n, out int[] c)
            {
                int max = n[0], n_id = 0, k;
                c = new int[n.Length - 1];
                for (int i = 1; i < n.Length; i++)
                {
                    if (n[i] > max)
                    {
                        max = n[i];
                        n_id = i;
                    }
                }
                for (int i = n_id; i < n.Length - 1; i++)
                {
                    k = n[i];
                    n[i] = n[i + 1];
                    n[i + 1] = k;
                }
                for (int i = 0; i < n.Length - 1; i++)
                {
                    c[i] = n[i];
                }
            }
        }
    }
}