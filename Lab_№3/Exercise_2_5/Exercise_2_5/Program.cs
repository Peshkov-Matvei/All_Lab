namespace Exercise_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxim = -10000, minim = 10000; 
            int[] c = new int[5];
            int[] f = new int[7];
            Console.WriteLine("Введите 5 значений массива через пробел");
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < 5; i++)
            {
                c[i] = int.Parse(s[i]);
                maxim = Math.Max(maxim, c[i]);
                minim = Math.Min(minim, c[i]);
            }
            f[0] = minim;
            f[6] = maxim;
            for (int i = 1; i < 6; i++)
            {
                f[i] = -1 * c[i - 1];
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", f[i]);
            }

        }
    }
}