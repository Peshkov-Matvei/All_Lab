namespace Exersice_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1, b = 0.8, h = 0.1, c = 0.0001, s, g, x;
            int n = (int)((b - a) / h + 1);
            x = a;
            for (int j = 1; j <= n; j++)
            {
                s = 1; g = 1;
                for (int i = 1; Math.Abs(g) >= c; i += 1)
                {
                    g = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
                    s += g;
                }
                Console.WriteLine(x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + Math.Pow(x, 2)));
                x += h;
                /*  0,08140964393544778
                    0,18677936350519364
                    0,3186429098779894
                    0,47591414437456925
                    0,6512392830509104
                    0,8294964000072794
                    0,9898495063120468
                    1,1121765727275472
                */
            }
        }
    }
}