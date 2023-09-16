namespace Exercise_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, a, b, r1, r2;
            string start = "-";
            int count = 0;
            Console.WriteLine("Введите кординаты центра окружностей по оси ox");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кординаты центра окружностей по оси oy");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус маленькой окружности");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус большой окружности");
            r2 = Convert.ToInt32(Console.ReadLine());
            if (r2 > r1)
            {
                do
                {
                    Console.WriteLine("Введите кординаты точки по оси ox");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите кординаты точки по оси oy");
                    y = Convert.ToInt32(Console.ReadLine());
                    if ((Math.Pow(x - a, 2) + Math.Pow(y - b, 2) >= r1 * r1) && (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= r2 * r2))
                    {
                        count += 1;
                    }
                    Console.WriteLine("Напишите '+', если хотите добавить новую точку.");
                    Console.WriteLine("Напишите '-', если не хотите добавить новую точку.");
                    start = Console.ReadLine();
                } while(start == "+");
                Console.WriteLine("Количество точек в кольце: {0}", count);
            }
            else
            {
                Console.WriteLine("Ошибка, были введены неправильные данные");
            }
        }
    }
}