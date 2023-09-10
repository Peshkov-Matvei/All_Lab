namespace Exercise_1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 3, old_chis = 1, old_znam = 1, znam = 1, chis = 2, x = 1, y = 2;
            for (int i = 0; i <= 5; i++)
            {
                x = chis;
                y = znam;
                chis = chis + old_chis;
                old_chis =  x;
                znam = znam + old_znam;
                old_znam =  y;
                s += chis / znam;
            }
            Console.WriteLine(s);
        }
    }
}