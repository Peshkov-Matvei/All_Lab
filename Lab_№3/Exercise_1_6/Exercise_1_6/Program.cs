namespace Exercise_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int[] a = new int[5];
            Console.WriteLine("Введите значения вектора через пробел");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(c[i]);
            }
            for (int j = 0; j < 5; j++)
            {
                summa += a[j];
            }
            Console.WriteLine(Math.Sqrt(summa));
        }
    }
}