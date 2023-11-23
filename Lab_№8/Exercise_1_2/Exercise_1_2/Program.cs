namespace Exercise_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c, text = "Бобры живут на реке. Они отличные строители. У бобров зубы острые, как бритва. На реке бобры делают плотины из стволов осины.";
            string[] mas = text.Split(' ');
            for (int i = 0; i < mas.Length; i++)
            {
                char[] t = mas[i].ToArray();
                Array.Reverse(t);
                c = new string(t);
                Console.Write(c + " ");
                mas[i] = c;
            }
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                char[] t = mas[i].ToArray();
                Array.Reverse(t);
                c = new string(t);
                Console.Write(c + " ");
            }
        }
    }
}