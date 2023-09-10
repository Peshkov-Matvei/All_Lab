namespace Exercise_2_7_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, s = 10;
            int n = 0;
            while (n <= 7)
            {
                n += 1;
                x += s;
                s = 1.1 * s;
            }
            Console.WriteLine(x);
        }
    }
}