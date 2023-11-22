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
            jap[1] = new Opros("собака", "стойкость", "сакура");
            jap[2] = new Opros("сова", "смелость", "сакура");
            jap[3] = new Opros("кот", "терпимость", "сакура");
            jap[4] = new Opros("собака", "храбрость", "суши");
            jap[5] = new Opros("кот", "героизм", "бамбук");
            jap[6] = new Opros("пчела", "смелость", "камень");
            jap[7] = new Opros("лама", "никакая", "сакура");
            Dictionary<int, string> animal = new Dictionary<int, string>(jap.Length)
            {
                [1] = "кот",
                [2] = "Апельсин",
                [3] = "Груша"
            };
            int k;
            for (int i = 0; i < jap.Length; i++)
            {
                k = 0;
                foreach (var answer in animal)
                {
                    if (jap[i].answer1 == answer.Value)
                    {
                        
                    }
                }
            }
        }
    }
}