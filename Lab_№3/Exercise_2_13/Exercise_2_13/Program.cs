namespace Exercise_2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            Console.WriteLine("Введите значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(c[i]);
            }
            int sid = 0, smax = s[0];
            for (int i = 2; i < n; i += 2)
            {
                if (s[i] > smax)
                {
                    sid = i;
                    smax = s[i];
                }
            }
            s[sid] = sid;
            for (int i = 0; i < n; i++)
                Console.Write($"{s[i]} ");
        }
    }
}