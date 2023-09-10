namespace Exercise_1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong s = 0, start = 1;
            for (int i = 1; i <= 64; i++)
            {
                s += start;
                start *= 2;
            }
            Console.WriteLine(s);
        }
    }
}