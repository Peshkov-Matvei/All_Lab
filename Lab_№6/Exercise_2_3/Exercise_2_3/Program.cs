namespace Exercise_2_3
{
    internal class Program
    {
        struct Sportsman
        {
            public string familia;
            public double rez1, rez2, rez3, rez;
            public Sportsman(string familia1, double rez11, double rez21, double rez31)
            {
                familia = familia1;
                rez1 = rez11;
                rez2 = rez21;
                rez3 = rez31;
                rez = Math.Max(rez11, Math.Max(rez21, rez31)); 
            }
        }
        static void Main(string[] args)
        {
            double amax;
            int imax;
            Sportsman[] s = new Sportsman[6];
            s[0] = new Sportsman("Иванов", 40.0, 104.3, 33.1);
            s[1] = new Sportsman("Сидоров", 51.3, 52.4, 5.3);
            s[2] = new Sportsman("Петров", 2.3, 122.1, 103.4);
            s[3] = new Sportsman("Занудов", 43.4, 25.4, 44.9);
            s[4] = new Sportsman("Лунов", 55.5, 105.2, 92.0);
            s[5] = new Sportsman("Ленов", 2.56, 55.3, 3.5);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0} - {1}", s[i].familia, s[i].rez);
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                amax = s[i].rez;
                imax = i;
                for (int j = i + 1; j < 6; j++)
                {
                    if (s[j].rez > amax)
                    {
                        amax = s[j].rez;
                        imax = j;
                        Sportsman temp;
                        temp = s[imax];
                        s[imax] = s[i];
                        s[i] = temp;
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0} - {1}", s[i].familia, s[i].rez);
            }
        }
    }
}