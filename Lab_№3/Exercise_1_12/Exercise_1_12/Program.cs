namespace Exercise_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0, r = 0;
            int[] c = new int[8];
            Console.WriteLine("Введите 8 объектов массива через пробел");
            string[] s = (Console.ReadLine()).Split(" ");
            for (int i = 0; i < 8; i++)
            {
                c[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < 8; i++)
            {
                if (c[i] < 0)
                {
                    t = i;
                    r = c[i];
                }
            }
            Console.WriteLine("{0} {1}", r, t);
        }
    }
}