namespace Exercise_2_7_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, s = 10;
            for (int n = 1; n <= 7; n++)
            {
                x += s;
                s = 1.1 * s;
            }
            Console.WriteLine("{0:f4}", x);
        }
    }
}