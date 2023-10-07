namespace Exercise_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double srz;
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            Console.WriteLine("Введите значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(c[i]);
            }
            int smin = s[0], smax = s[0], summa = 0, maxid = 0, minid = 0;
            for (int i = 0; i < n; i++)
            {
                if (smin > s[i])
                {
                    smin = s[i];
                    minid = i;
                }
                if (smax < s[i])
                {
                    smax = s[i];
                    maxid = i;
                }
            }
            for (int i = Math.Min(minid, maxid) + 1; i < Math.Max(minid, maxid); i++)
            {
                summa += s[i];
            }
            srz = summa / (Math.Abs(minid - maxid) - 1.0);
            Console.WriteLine(srz);
        }
    }
}