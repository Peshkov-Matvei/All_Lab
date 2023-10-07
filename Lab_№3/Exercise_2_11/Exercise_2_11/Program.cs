namespace Exercise_2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            int[] f = new int[n + 1];
            Console.WriteLine("Введите значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            int last_id = 0;
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(c[i]);
                if (s[i] >= 0)
                {
                    last_id = i;
                }
            }
            Console.WriteLine("Введите число, которое нужно добавить в массив");
            int p = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < n + 1; i++)
            {
                if (i != last_id + 1)
                {
                    f[i] = s[j++];
                }
                else
                {
                    f[i] = p;
                }
                Console.Write("{0} ", f[i]);
            }
        }
    }
} 