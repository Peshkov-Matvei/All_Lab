namespace Exercise_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[10];
            int[] f = new int[5];
            int[] t = new int[5];
            Console.WriteLine("Введите 10 объектов массива через пробел");
            string[] s = (Console.ReadLine()).Split(" ");
            for (int i = 0; i < 10; i++)
            {
                c[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    f[i / 2] = c[i];
                }
                else
                {
                    t[i / 2] = c[i];
                }
            }
            for (int l = 0; l < 5; l++)
                {
                    Console.Write("{0} " , f[l]);
                }
            Console.WriteLine();
            for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} " , t[j]);
                }
        }
    }
}