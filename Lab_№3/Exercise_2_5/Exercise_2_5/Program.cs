namespace Exercise_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxim = -10000, minim = 10000, id_max = 0, id_min = 0, d = 0, min_count = 0;
            int[] c = new int[5];

            Console.WriteLine("Введите 5 значений массива через пробел");
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < 5; i++)
            {
                c[i] = int.Parse(s[i]);
                if (maxim < c[i])
                {
                    id_max = i;
                    maxim = c[i];
                }
                if (minim > c[i])
                {
                    id_min = i;
                    minim = c[i];
                }
                if (c[i] < 0)
                {
                    min_count++;
                }
            }
            int[] f = new int[min_count];
            for (int i = Math.Min(id_max, id_min) + 1; i < Math.Max(id_max, id_min); i++)
            {
                if (c[i] < 0)
                {
                    f[d] = c[i];
                    Console.Write("{0} ", f[d++]);
                }
            }
        }
    }
}