namespace Exercise_3_4
{
    class Sport
    {
        public string fam = " ";
        public int points;
        public void Sp(string fam, int points)
        {
            this.fam = fam;
            this.points = points;
        }
    }
    class Rangs : Sport
    {
        public int rang;
        public void Rang()
        {
            if (points >= 100) rang = 1;
            else rang = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rangs[] g1 = new Rangs[3];
            Rangs[] g2 = new Rangs[3];
            g1[0] = new Rangs();
            g1[0].Sp("Иванов", 110);
            g1[1] = new Rangs();
            g1[1].Sp("Сидоров", 134);
            g1[2] = new Rangs();
            g1[2].Sp("Петров", 98);
            g2[0] = new Rangs();
            g2[0].Sp("Занудов", 32);
            g2[1] = new Rangs();
            g2[1].Sp("Лунов", 140);
            g2[2] = new Rangs();
            g2[2].Sp("Ленов", 90);
            double amax;
            for (int i = 0; i < g1.Length; i++)
            {
                amax = g1[i].points;
                for (int j = i + 1; j < g1.Length; j++)
                {
                    if (amax < g1[j].points)
                    {
                        amax = g1[j].points;
                        Rangs temp;
                        temp = g1[j];
                        g1[j] = g1[i];
                        g1[i] = temp;
                    }
                }
            }
            Console.WriteLine("Группа 1:");
            for (int i = 0; i < g1.Length; i++)
            {
                Console.WriteLine("{0} - {1}", g1[i].fam, g1[i].points);
            }
            for (int i = 0; i < g2.Length; i++)
            {
                amax = g2[i].points;
                for (int j = i + 1; j < g2.Length; j++)
                {
                    if (amax < g2[j].points)
                    {
                        amax = g2[j].points;
                        Rangs temp;
                        temp = g2[j];
                        g2[j] = g2[i];
                        g2[i] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Группа 2:");
            for (int i = 0; i < g2.Length; i++)
            {
                Console.WriteLine("{0} - {1}", g2[i].fam, g2[i].points);
            }
            Rangs[] ag = new Rangs[g1.Length + g2.Length];
            int t = 0;
            for (; t < g1.Length; t++)
            {
                ag[t] = new Rangs();
                ag[t].Sp(g1[t].fam, g1[t].points);
            }
            for (; t < g1.Length + g2.Length; t++)
            {
                ag[t] = new Rangs();
                ag[t].Sp(g2[t - g1.Length].fam, g2[t - g1.Length].points);
            }
            Console.WriteLine();
            for (int i = 0; i < ag.Length; i++)
            {
                amax = ag[i].points;
                for (int j = i + 1; j < ag.Length; j++)
                {
                    if (amax < ag[j].points)
                    {
                        amax = ag[j].points;
                        Rangs temp;
                        temp = ag[j];
                        ag[j] = ag[i];
                        ag[i] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Список участников соревнования:");
            for (int i = 0; i < ag.Length; i++)
            {
                ag[i].Rang();
                Console.WriteLine("{0} - {1}. Спортивный разряд - {2}", ag[i].fam, ag[i].points, ag[i].rang);
            }
        }
    }
}