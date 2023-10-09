namespace Exercise_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int l;
            if (n % 2 == 0)
            {
                l = n;
            }
            else
            {
                l = n + 1;
            }
            int[] b = new int[l];
            Console.WriteLine("Введите значения массива через пробел");
            string[] c = Console.ReadLine().Split();
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
                if (i % 2 == 0)
                {
                    b[r++] = int.Parse(c[i]);
                }
            }
            Array.Sort(b);
            int j = 0;
            for (int i = 0; i < n; i+=2)
            {
                a[i] = b[j++];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}