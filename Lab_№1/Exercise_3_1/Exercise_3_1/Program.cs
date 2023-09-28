namespace Exercise_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1, b = 1.0, h = 0.1, x = 0.1, c = 0.0001, p, fact, s, n, g;
            n = (b - a) / h + 1;
            for (int j = 1; j <= n; j++)
            {
                g = 1; s = 0; fact = 1; p = -1.0;
                for (int i = 0; Math.Abs(g) >= c; i++)
                {
                    p = -p;
                    for (int t = 1; t <= 2 * i; t++)
                    {
                        fact *= t;
                    }
                    g = p * Math.Pow(x, 2 * i) / fact;
                    s += g;
                }
                Console.WriteLine("{0:f4} {1:f4}", Math.Cos(x), s);
                x += h;
            }
        }
    }
}
