namespace Exercise_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1, b = 0.8, h = 0.1, c = 0.0001, s, g, x;
            int n = (int) ((b - a) / h + 1);
            x = a;
            for (int j = 1; j <= n; j++)
            {
                s = 1; g = 1;
                for (int i = 1; Math.Abs(g) >= c; i += 1)
                {
                    g = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
                    s += g;
                }
                Console.WriteLine(x * Math.Sin(Math.PI/4)/(1 - 2 * x * Math.Cos(Math.PI/4) + Math.Pow(x, 2)));
                x += h;
            }
        }
    }
}