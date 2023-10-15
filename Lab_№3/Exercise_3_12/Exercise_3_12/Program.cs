namespace Exercise_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 12, l = 0, d = 0;
            int[] a = new int[n];
            Console.WriteLine("Введите 12 значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
                if (a[i] < 0) l++;
            }
            int[] b = new int[n - l];
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                {
                    b[d] = a[i];
                    Console.Write("{0} ", b[d++]);
                }
            }
        }
    }
}