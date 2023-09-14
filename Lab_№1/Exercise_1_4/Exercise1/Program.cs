namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0, x = 13;
            for (int i = 0; i <= 9; i++)
            {
                s += Math.Cos(x * i) / Math.Pow(x, i - 1);
            }
            Console.WriteLine("{0:f4}", s);
        }
    }
}