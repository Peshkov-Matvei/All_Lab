using System.Linq;
namespace Exercise_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите значения массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(c[i]);
            }
            int[] f = a.Distinct().ToArray();
            Console.WriteLine(String.Join(" ", f));
        }
    }
}