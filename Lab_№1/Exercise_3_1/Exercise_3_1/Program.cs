namespace Exercise_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1, b = 1.0, h = 0.1, x = 0.1, c = 0.0001, p = -1.0, fact, s, n, g;
            n = (b - a) / h + 1;
            for (int j = 1; j <= n; j++)
            {
                g = 1; s = 1; fact = 1;
                for  (int i = 0; Math.Abs(g) >= c; i++)
                {
                    p = - p; 
                    for (int t = 1; t <= 2 * i; t++)
                    {
                        fact *= t;
                    }
                    g = p * Math.Pow(x, 2 * i) / fact;
                    s += g;
                }
                Console.WriteLine(Math.Cos(x));
                x += h;
                /*  
                0,9950041652780258
                0,9800665778412416
                0,955336489125606
                0,9210609940028851
                0,8775825618903728
                0,8253356149096783
                0,7648421872844885
                0,6967067093471655
                0,6216099682706645
                0,5403023058681398
                */
            }
        }
    }
}