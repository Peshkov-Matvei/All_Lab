namespace Exercise_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 8, b1 = 9, c1 = 5, a2 = 6, b2 = 3, c2 = 7;
            double s1, s2;
            S(a1, b1, c1, out s1);
            S(a2, b2, c2, out s2);
            if (s1 > s2)
            {
                Console.WriteLine("Первый треугольник больше второго: {0:f2} > {1:f2}", s1, s2);
            }
            else
            {
                Console.WriteLine("Второй треугольник больше первого: {0:f2} < {1:f2}", s1, s2);
            }
            static void S(int a, int b, int c, out double s)
            {
                int p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}