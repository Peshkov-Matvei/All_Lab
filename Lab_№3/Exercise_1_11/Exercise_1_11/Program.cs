namespace Exercise_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[10];
            Console.WriteLine("Введите 10 объектов массива через пробел");
            string[] s = (Console.ReadLine()).Split();
            for (int i = 0; i < 10; i++)
            {
                c[i] = Math.Abs(int.Parse(s[i]));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", c[i]);
            }
        }
    }
}