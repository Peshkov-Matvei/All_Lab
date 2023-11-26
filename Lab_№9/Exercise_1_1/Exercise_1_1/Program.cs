namespace Exercise_3_1
{
    class Student
    {
        public string familia = " ";
        public int rez1, rez2, rez3, rez4, rez5;
        public double srz;
        public void Getsrz(string familia1, int rez11, int rez21, int rez31, int rez41, int rez51)
        {
            familia = familia1;
            rez1 = rez11;
            rez2 = rez21;
            rez3 = rez31;
            rez4 = rez41;
            rez5 = rez51;
            srz = (rez1 + rez2 + rez3 + rez4 + rez5) / 5.0;
        }
    }
    class StudentStep : Student
    {
        public double step;
        public void Step()
        {
            step = srz * 1000;
        }
    }
    class Group
    {
        public int number;
        public int count;
        public double srz, sum;
        public Group(int number1, int count1, double sum1)
        {
            number = number1;
            count = count1;
            sum = sum1;
            srz = sum / count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter text = new StreamWriter("text.txt");
            text.WriteLine(1);
            Console.WriteLine(text);
            double sum1 = 0, sum2 = 0, sum3 = 0;
            StudentStep[] s1 = new StudentStep[3];
            s1[0] = new StudentStep();
            s1[0].Getsrz("Иванов", 5, 4, 3, 5, 2);
            s1[1] = new StudentStep();
            s1[1].Getsrz("Сидоров", 4, 5, 3, 4, 5);
            s1[2] = new StudentStep();
            s1[2].Getsrz("Петров", 5, 5, 5, 5, 5);
            StudentStep[] s2 = new StudentStep[2];
            s2[0] = new StudentStep();
            s2[0].Getsrz("Занудов", 3, 5, 2, 3, 3);
            s2[1] = new StudentStep();
            s2[1].Getsrz("Лунов", 4, 5, 5, 4, 3);
            StudentStep[] s3 = new StudentStep[2];
            s3[0] = new StudentStep();
            s3[0].Getsrz("Ленов", 5, 5, 5, 5, 4);
            s3[1] = new StudentStep();
            s3[1].Getsrz("Троцкий", 5, 5, 5, 2, 5);
            for (int i = 0; i < s1.Length; i++)
            {
                sum1 += s1[i].srz;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i].srz;
            }
            for (int i = 0; i < s3.Length; i++)
            {
                sum3 += s3[i].srz;
            }
            Group[] g = new Group[3];
            g[0] = new Group(1, s1.Length, sum1);
            g[1] = new Group(2, s2.Length, sum2);
            g[2] = new Group(3, s3.Length, sum3);
            double amax;
            for (int i = 0; i < s1.Length; i++)
            {
                amax = s1[i].srz;
                for (int j = i + 1; j < s1.Length; j++)
                {
                    if (amax < s1[j].srz)
                    {
                        amax = s1[j].srz;
                        StudentStep temp;
                        temp = s1[j];
                        s1[j] = s1[i];
                        s1[i] = temp;
                    }
                }
            }
            Console.WriteLine("Группа 1:");
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].srz >= 4.0)
                {
                    s1[i].Step();
                    Console.WriteLine("{0} - {1}. Стипендия - {2}", s1[i].familia, s1[i].srz, s1[i].step);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < s2.Length; i++)
            {
                amax = s2[i].srz;
                for (int j = i + 1; j < s2.Length; j++)
                {
                    if (amax < s2[j].srz)
                    {
                        amax = s2[j].srz;
                        StudentStep temp;
                        temp = s2[j];
                        s2[j] = s2[i];
                        s2[i] = temp;
                    }
                }
            }
            Console.WriteLine("Группа 2:");
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i].srz >= 4.0)
                {
                    s2[i].Step();
                    Console.WriteLine("{0} - {1}. Стипендия - {2}", s2[i].familia, s2[i].srz, s2[i].step);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < s3.Length; i++)
            {
                amax = s3[i].srz;
                for (int j = i + 1; j < s3.Length; j++)
                {
                    if (amax < s3[j].srz)
                    {
                        amax = s3[j].srz;
                        StudentStep temp;
                        temp = s3[j];
                        s3[j] = s3[i];
                        s3[i] = temp;
                    }
                }
            }
            Console.WriteLine("Группа 3:");
            for (int i = 0; i < s3.Length; i++)
            {
                if (s3[i].srz >= 4.0)
                {
                    s3[i].Step();
                    Console.WriteLine("{0} - {1}. Стипендия - {2}", s3[i].familia, s3[i].srz, s3[i].step);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < g.Length; i++)
            {
                amax = g[i].srz;
                for (int j = i + 1; j < g.Length; j++)
                {
                    if (amax < g[j].srz)
                    {
                        amax = g[j].srz;
                        Group temp;
                        temp = g[j];
                        g[j] = g[i];
                        g[i] = temp;
                    }
                }
            }
            Console.WriteLine("Список групп:");
            for (int i = 0; i < g.Length; i++)
            {
                Console.WriteLine("Группа под номером - {0} имеет средний балл - {1:f2}", g[i].number, g[i].srz);
            }
        }
    }
}