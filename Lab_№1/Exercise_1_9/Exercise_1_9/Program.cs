namespace Exercise_1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0, a = 1;
            for (int i = 1; i <= 6; i++)
            {
                a *= i;
                s += Math.Pow(-1, i) * Math.Pow(5, i) / a;
            }
            Console.WriteLine(s);
        }
    }
}