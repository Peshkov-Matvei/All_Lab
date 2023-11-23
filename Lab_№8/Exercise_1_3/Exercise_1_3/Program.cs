namespace Exercise_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Бобры живут на реке. Они отличные строители. У бобров зубы острые, как бритва. На реке бобры делают плотины из стволов осины.";
            string[] mas = text.Split(' ');
            string t = mas[0];
            int a = mas[0].Length;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i].Length + a + 1 <= 50)
                {
                    a += mas[i].Length + 1;
                    t += " " + mas[i];
                }
                else
                {
                    Console.WriteLine(t);
                    a = mas[i].Length;
                    t = mas[i];
                }
            }
            Console.WriteLine(t);
        }
    }
}