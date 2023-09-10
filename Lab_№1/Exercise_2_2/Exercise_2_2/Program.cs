using System.ComponentModel;
using System.Reflection.Metadata;

namespace Exercise_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int L = 30000;
            int p = 1, c = 1;
            for (int n = 1; p * n <= L; n += 3)
            {
                p *= n;
                c = n;
            }
            Console.WriteLine(c);
        }
    }
}