namespace Exersice_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, s, R, d;
            r = Convert.ToDouble(Console.ReadLine());
            s = Convert.ToDouble(Console.ReadLine());
            R = Math.Round(Math.Sqrt(r / Math.PI), 4);
            d = Math.Round(Math.Sqrt(2 * s) / 2, 4);
            if (R > d)
            {
                Console.WriteLine("Квадрат поместится в круг");
            }
            else
            {
                Console.WriteLine("Квадрат не поместится в круг");
            }
        }
    }
}