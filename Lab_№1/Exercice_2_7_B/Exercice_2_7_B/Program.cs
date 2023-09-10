namespace Exercice_2_7_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 10, c = 0;
            int n = 0;
            while (c < 100)
            {
                n += 1;
                c += s;
                s = 1.1 * s;

            }
            Console.WriteLine(n);
        }
    }
}