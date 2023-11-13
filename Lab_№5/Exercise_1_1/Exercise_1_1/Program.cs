namespace Exercise_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 5, n1 = 8, n2 = 10, n3 = 11;
            double f1, f2, f3, fk, fkn1, fkn2, fkn3, c1, c2, c3;
            Fact(n1, out f1);
            Fact(n2, out f2);
            Fact(n3, out f3);
            Fact(k, out fk);
            Fact(n1 - k, out fkn1);
            Fact(n2 - k, out fkn2);
            Fact(n3 - k, out fkn3);
            c1 = f1 / (fk * fkn1);
            c2 = f2 / (fk * fkn2);
            c3 = f3 / (fk * fkn3);
            Console.WriteLine("Для 8 человек: {0}", c1);
            Console.WriteLine("Для 10 человек: {0}", c2);
            Console.WriteLine("Для 11 человек: {0}", c3);
            static void Fact(int n, out double nf)
            {
                nf = 1;
                for (int i = 1; i <= n; i++)
                {
                    nf *= i;
                }
            }
        }
    }
}