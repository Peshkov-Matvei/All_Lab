namespace Exercise_2_1
{
    internal class Program
    {
        struct Student
        {
            public string famile;
            public int rez1, rez2, rez3, rez4;
            public double srz;
            public Student(string famile1, int rez11, int rez21, int rez31, int rez41)
            {
                famile = famile1;
                rez1 = rez11;
                rez2 = rez21;
                rez3 = rez31;
                rez4 = rez41;
                srz = (rez1 + rez2 + rez3 + rez4) / 4.0;
            }
        }
        static void Main(string[] args)
        {
            Student[] sp1 = new Student[4];
            Console.WriteLine("Первая группа");
            sp1[0] = new Student("Иванов", 4, 4, 3, 5);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp1[0].famile, sp1[0].srz);
            sp1[1] = new Student("Сидоров", 5, 5, 5, 5);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp1[1].famile, sp1[1].srz);
            sp1[2] = new Student("Петров", 2, 2, 3, 2);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp1[2].famile, sp1[2].srz);
            sp1[3] = new Student("Ленов", 2, 5, 3, 2);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp1[3].famile, sp1[3].srz);
            Console.WriteLine();
            Student[] sp2 = new Student[3];
            Console.WriteLine("Вторая группа");
            sp2[0] = new Student("Занудов", 4, 5, 4, 3);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp2[0].famile, sp2[0].srz);
            sp2[1] = new Student("Лунов", 5, 5, 2, 5);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp2[1].famile, sp2[1].srz);
            sp2[2] = new Student("Ленов", 2, 5, 3, 2);
            Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp2[2].famile, sp2[2].srz);
            Console.WriteLine();
            Console.WriteLine("Отсортированные группы");
            Console.WriteLine();
            Console.WriteLine("Первая группа");
            for (int i = 0; i < sp1.Length - 1; i++)
            {
                double amax = sp1[i].srz;
                int imax = i;
                for (int j = i + 1; j < sp1.Length - 1; j++)
                {
                    if (sp1[j].srz > amax)
                    {
                        amax = sp1[j].srz;
                        imax = j;
                        Student temp;
                        temp = sp1[imax];
                        sp1[imax] = sp1[i];
                        sp1[i] = temp;
                    }
                }
            }
            for (int i = 0; i < sp1.Length; i++)
            {
                if (sp1[i].srz >= 4.0)  Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp1[i].famile, sp1[i].srz);
            }
            Console.WriteLine();
            for (int i = 0; i < sp2.Length - 1; i++)
            {
                double amax = sp2[i].srz;
                int imax = i;
                for (int j = i + 1; j < sp2.Length - 1; j++)
                {
                    if (sp2[j].srz > amax)
                    {
                        amax = sp2[j].srz;
                        imax = j;
                        Student temp;
                        temp = sp2[imax];
                        sp2[imax] = sp2[i];
                        sp2[i] = temp;
                    }
                }
            }
            for (int i = 0; i < sp2.Length; i++)
            {
                if (sp2[i].srz >= 4.0) Console.WriteLine("Фамилия: {0}, Средний балл: {1}", sp2[i].famile, sp2[i].srz);
            }
        }
    }
}