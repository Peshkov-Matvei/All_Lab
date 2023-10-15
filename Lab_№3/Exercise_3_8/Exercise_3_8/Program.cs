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
            int r = 0, l = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
                if (a[i] < 0)
                {
                    l++;
                }
            }
            int[] b = new int[l];
        }
    }
}