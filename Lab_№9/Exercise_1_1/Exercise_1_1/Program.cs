using System;
using System.Text;
using System.IO;

namespace Exercise_3_4
{
    internal class Program
    {
        struct Sport
        {
            public string fam;
            public int points;
            public Sport(string fam, int points)
            {
                this.fam = fam;
                this.points = points;
            }
        }
        static void Main(string[] args)
        {
            Sport[] g1 = new Sport[3];
            Sport[] g2 = new Sport[3];
            double amax;
            string line;
            string path = @"D:\Dev\test.txt";
            int w = 0;
            StreamReader sr = new StreamReader(path);
            while (((line = sr.ReadLine()) != null) && (w != 3))
            {
                string[] sport = line.Split(' ');
                g1[w].fam = sport[0];
                g1[w].points = int.Parse(sport[1]);
                w++;
            }
            while ((line = sr.ReadLine()) != null)
            {
                string[] sport = line.Split(' ');
                g2[w].fam = sport[0];
                g2[w].points = int.Parse(sport[1]);
                w++;
            }
            for (int i = 0; i < g1.Length; i++)
            {
                amax = g1[i].points;
                for (int j = i + 1; j < g1.Length; j++)
                {
                    if (amax < g1[j].points)
                    {
                        amax = g1[j].points;
                        Sport temp;
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
                        Sport temp;
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
            Sport[] ag = new Sport[g1.Length + g2.Length];
            int t = 0;
            for (; t < g1.Length; t++)
            {
                ag[t] = new Sport(g1[t].fam, g1[t].points);
            }
            for (; t < g1.Length + g2.Length; t++)
            {
                ag[t] = new Sport(g2[t - g1.Length].fam, g2[t - g1.Length].points);
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
                        Sport temp;
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
                Console.WriteLine("{0} - {1}", ag[i].fam, ag[i].points);
            }
        }
    }
}
