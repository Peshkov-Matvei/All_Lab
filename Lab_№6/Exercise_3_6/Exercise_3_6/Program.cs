using System;

namespace Exercise_3_6
{
    internal class Program
    {
        public struct Opros
        {
            public string answer1, answer2, answer3;
            public Opros(string answer1, string answer2, string answer3)
            {
                this.answer1 = answer1;
                this.answer2 = answer2;
                this.answer3 = answer3;
            }
        }
        static void Main(string[] args)
        {
            Opros[] jap = new Opros[8];
            jap[0] = new Opros("кот", "смелость", "остров");
            jap[1] = new Opros("сом", "стойкость", "сакура");
            jap[2] = new Opros("собака", "смелость", "сакура");
            jap[3] = new Opros("кот", "никакая", "сакура");
            jap[4] = new Opros("собака", "храбрость", "суши");
            jap[5] = new Opros("кот", "героизм", "бамбук");
            jap[6] = new Opros("пчела", "смелость", "сакура");
            jap[7] = new Opros("лама", "никакая", "сакура");
            int k, t;
            string g;
            bool flag;
            int[] answer11 = new int[jap.Length];
            int[] answer12 = new int[jap.Length];
            int[] answer13 = new int[jap.Length];
            var answer1 = new Dictionary<int, string>();
            var answer2 = new Dictionary<int, string>();
            var answer3 = new Dictionary<int, string>();
            for (int i = 0; i < jap.Length; i++)
            {
                flag = true;
                for (int j = 0; j < answer1.Count; j++)
                {
                    if (jap[i].answer1 == answer1[j])
                    {
                        answer11[j] += 1;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    answer11[answer1.Count] += 1;
                    answer1[answer1.Count] = jap[i].answer1;
                }
            }
            for (int i = 0; i < jap.Length; i++)
            {
                flag = true;
                for (int j = 0; j < answer2.Count; j++)
                {
                    if (jap[i].answer2 == answer2[j])
                    {
                        answer12[j] += 1;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    answer12[answer2.Count] += 1;
                    answer2[answer2.Count] = jap[i].answer2;
                }
            }
            for (int i = 0; i < jap.Length; i++)
            {
                flag = true;
                for (int j = 0; j < answer3.Count; j++)
                {
                    if (jap[i].answer3 == answer3[j])
                    {
                        answer13[j] += 1;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    answer13[answer3.Count] += 1;
                    answer3[answer3.Count] = jap[i].answer3;
                }
            }
            do
            {
                k = 0;
                for (int i = 0; i < answer11.Length - 1; i++)
                {
                    if (answer11[i] < answer11[i + 1])
                    {
                        t = answer11[i];
                        answer11[i] = answer11[i + 1];
                        answer11[i + 1] = t;
                        g = answer1[i];
                        answer1[i] = answer1[i + 1];
                        answer1[i + 1] = g;
                        k += 1;
                    }
                }
                for (int i = 0; i < answer12.Length - 1; i++)
                {
                    if (answer12[i] < answer12[i + 1])
                    {
                        t = answer12[i];
                        answer12[i] = answer12[i + 1];
                        answer12[i + 1] = t;
                        g = answer2[i];
                        answer2[i] = answer2[i + 1];
                        answer2[i + 1] = g;
                        k += 1;
                    }
                }
                for (int i = 0; i < answer13.Length - 1; i++)
                {
                    if (answer13[i] < answer13[i + 1])
                    {
                        t = answer13[i];
                        answer13[i] = answer13[i + 1];
                        answer13[i + 1] = t;
                        g = answer3[i];
                        answer3[i] = answer3[i + 1];
                        answer3[i + 1] = g;
                        k += 1;
                    }
                }
            } while (k > 0);
            Console.WriteLine("Пяти наиболее часто встречающихся ответов на первый вопрос");
            k = 0;
            for (int i = 0; i < answer1.Count; i++)
            {
                Console.WriteLine("{0} - {1}%", answer1[i], answer11[i] * 100.0 / jap.Length);
                if (++k == 5) break;
            }
            Console.WriteLine();
            Console.WriteLine("Пяти наиболее часто встречающихся ответов на второй вопрос");
            k = 0;
            for (int i = 0; i < answer2.Count; i++)
            {
                Console.WriteLine("{0} - {1}%", answer2[i], answer12[i] * 100.0 / jap.Length);
                if (++k == 5) break;
            }
            Console.WriteLine();
            Console.WriteLine("Пяти наиболее часто встречающихся ответов на третий вопрос");
            k = 0;
            for (int i = 0; i < answer3.Count; i++)
            {
                Console.WriteLine("{0} - {1}%", answer3[i], answer13[i] * 100.0 / jap.Length);
                if (++k == 5) break;
            }
        }
    }
}