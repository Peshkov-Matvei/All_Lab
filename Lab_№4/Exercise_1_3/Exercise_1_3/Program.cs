namespace Exercise_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int[,] a = new int[4, 4] { 
                                    { 1, 2, 3, 4},
                                    { 5, 6, 7, 8},
                                    { 9, 10, 11, 12},
                                    { 13, 14, 15, 16} 
                                    };
            for (int i = 0; i < 4; i++)
            {
                summa += a[i, i] + a[3 - i, i];
            }
            Console.WriteLine(summa);
        }
    }
}