namespace Exercise_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = 1, m = 1, max = 0;
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите значения массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] <= a[i + 1]) l++;
                else 
                {
                    max = Math.Max(max, l);
                    l = 1; 
                }
                if (a[i] >= a[i + 1]) m++;
                else
                {
                    max = Math.Max(max, m);
                    m = 1;
                }
            }
            Console.WriteLine(Math.Max(l, Math.Max(m, max)));
        }
    }
}
