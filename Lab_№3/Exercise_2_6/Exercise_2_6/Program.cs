using System.Linq;
namespace Exercise_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            Console.WriteLine("Введите значений массива через пробел");
            string[] c = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(c[i]);
            }
            int srz = s.Sum() / 2;
            Console.WriteLine("Введите число");
            int p = int.Parse(Console.ReadLine());
            int raz = Math.Abs(srz - s[0]);
            int s_id = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (raz > Math.Abs(srz - s[i]))
                {
                    raz = Math.Abs(srz - s[i]);
                    s_id = i;
                }
            }
            int[] f = new int[s.Length+1];
            for (int j = 0; j < f.Length; j++)
            {
                if (j <= s_id)
                {
                    f[j] = s[j];
                }
                else if (j == s_id + 1)
                {
                    f[j] = p;
                }
                else
                {
                    f[j] = s[j - 1];
                }
            }
            foreach (int num in f)
            {
                Console.Write($"{num} ");
            }
                
        }
    }
}