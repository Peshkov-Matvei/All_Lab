namespace Exercise_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int f = 0;
            string start = "-";
            do
            {
                Console.WriteLine("Введите a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберете фигуру: 1 - прямоугольник, 2 - кольца, 3 - р.б треугольник");
                f = Convert.ToInt32(Console.ReadLine());
                switch (f)
                {
                    case 1:
                        Console.WriteLine(a * b);
                        break;
                    case 2:
                        Console.WriteLine(Math.Abs((a * a * Math.PI) - (b * b * Math.PI)));
                        break;
                    case 3:
                        Console.WriteLine(0.5 * a * (Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a / 2, 2))));
                        break;
                }
                Console.WriteLine("Введите +, если хотите продолжить");
                Console.WriteLine("Введите -, если хотите закончить");
                start = Console.ReadLine();
            } while (start == "+");
        }
    }
}