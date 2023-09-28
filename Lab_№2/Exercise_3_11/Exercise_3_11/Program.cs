namespace Exercise_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0, a, b, c, d, n = 0;
            double s = 0;
            string start = "-";
            do
            {
                Console.WriteLine("Введите оценки ученика по первому предмету");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценки ученика по второму предмету");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценки ученика по третьему предмету");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оценки ученика по четвертому предмету");
                d = Convert.ToInt32(Console.ReadLine());
                if ((a <= 5) && (b <= 5) && (c <= 5) && (d <= 5))
                {
                    count++;
                    if ((a <= 2) || (b <= 2) || (c <= 2) || (d <= 2))
                    {
                        n++;
                    }
                    s += a + b + c + d;
                }
                else
                {
                    Console.WriteLine("Были введены неправильные данные");
                }
                Console.WriteLine("Введите '+', если хотите добавить ученика");
                Console.WriteLine("Введите '-', если не хотите добавить ученика");
                start = Console.ReadLine();
            } while (start == "+");
            Console.WriteLine("Средни балл класса: {0}", s / (4 * count));
            Console.WriteLine("Количество неуспевающих учеников: {0}", n);
        }
    }
}
