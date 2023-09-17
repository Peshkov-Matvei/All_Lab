namespace Exercise_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            int f = 0;
            string start = "-";
            do
            {
                Console.WriteLine("Введите r");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберете фигуру: 1 - квадрат, 2 - круг, 3 - р.c треугольник");
                f = Convert.ToInt32(Console.ReadLine());
                switch (f)
                {
                    case 1:
                        Console.WriteLine(r * r);
                        break;
                    case 2:
                        Console.WriteLine(r * r * Math.PI);
                        break;
                    case 3:
                        Console.WriteLine(0.5 * r * r * Math.Sqrt(3) / 2);
                        break;
                }
                Console.WriteLine("Введите +, если хотите продолжить");
                Console.WriteLine("Введите -, если хотите закончить");
                start = Console.ReadLine();
            } while (start == "+");
        }
    }
}