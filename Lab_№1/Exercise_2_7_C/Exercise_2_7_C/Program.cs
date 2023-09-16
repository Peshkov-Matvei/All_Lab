
namespace Exercise_2_7_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 10;
            int n = 1;
            while (s <= 20)
            {
                n += 1;
                s *= 1.1;
            }
            Console.WriteLine(n);
        }
    }
}