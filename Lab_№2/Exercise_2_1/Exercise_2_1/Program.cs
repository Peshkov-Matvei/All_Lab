namespace Exercise_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, count_g = 0, count_b = 0, h_b, h_g;
            double g = 0, b = 0;
            Console.WriteLine("Введите количество учеников");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество девочек");
            count_g = Convert.ToInt32(Console.ReadLine());
            if (count_g <= n)
            {
                count_b = n - count_g;
                for  (int i = 0; i < count_g; i++)
                {
                    Console.WriteLine("Введите рост девочки");
                    h_g = Convert.ToInt32(Console.ReadLine());
                    g += h_g;
                }
                for (int i = 0; i < count_b; i++)
                {
                    Console.WriteLine("Введите рост мальчика");
                    h_b = Convert.ToInt32(Console.ReadLine());
                    b += h_b;
                }
                Console.WriteLine("Средний рост девочек в классе - {0:f2}, средний рост мальчиков - {1:f2}", g / count_g, b / count_b);
            }
            else
            {
                Console.WriteLine("Ошибка, количество девочек не может превышать колличество учеников в классе!!!");
            }



        }
    }
}