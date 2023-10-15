namespace Exercise_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите значения массива через пробел");
            string[] c = Console.ReadLine().Split();
            string s = "";
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
                if (a[i] < 0)
                {
                    s += (c[i] + " ");
                }
            }
            string[] b = s.Split();
            int[] f = new int[b.Length - 1];
            for (int i = 0; i < b.Length - 1; i++)
            {
                f[i] = int.Parse(b[i]);
            }
            Array.Sort(f);
            int q = f.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = f[q--];
                }
                Console.Write("{0} ", a[i]);
            }
        }
    }
}