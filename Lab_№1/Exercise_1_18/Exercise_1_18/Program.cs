namespace Exercise_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                n *= 2;
                Console.WriteLine("Спустя {0} ч будет {1} клеток", i, n);
            }
        }
    }
}