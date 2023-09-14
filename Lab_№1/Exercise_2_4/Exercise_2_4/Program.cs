namespace Exercise_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double e = 0.0001;
            double s = 1, x;
            Console.Write("Введите число, которое по модулю будет меньше 1 - ");
            x = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x) < 1)
            {
                for (int i = 2; Math.Pow(x, i - 2) >= e; i+=2)
                {
                    s += Math.Pow(x, i);
                }
                Console.WriteLine("{0:f4}", s);
            }
            
        }
    }
}