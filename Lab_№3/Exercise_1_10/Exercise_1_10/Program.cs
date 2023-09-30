 namespace Exercise_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p, q;
            int q_id = 0, p_id = 0;
            string[] c = new string[10]; 
            Console.WriteLine("Введите 10 объектов массива через пробел");
            string[] s = (Console.ReadLine()).Split();
            for (int i = 0; i < 10; i++)
            {
                c[i] = s[i];
            }
            Console.WriteLine("Введите p");
            p = Console.ReadLine();
            Console.WriteLine("Введите q");
            q = Console.ReadLine();
            if (int.Parse(p) < int.Parse(q))
            {
                for (int l = 0; l < 10; l++)
                { 
                    if (c[l] == q)
                    {
                        q_id = l;
                    }
                    else if (c[l] == p)
                    {
                        p_id = l;
                    }
                }
                Console.WriteLine(Math.Abs(p_id - q_id) - 1);
            }
            else
            {
                Console.WriteLine("Введены неправильные данные");
            }
        }
    }
}