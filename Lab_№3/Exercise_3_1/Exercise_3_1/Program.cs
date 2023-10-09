namespace Exercise_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("Введите значения массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
            }
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == a.Max())
                {
                    b[t] = i;
                    Console.Write($"{b[t++]} ");
                }
            }
        }
    }
}