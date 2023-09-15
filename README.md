# Репозиторий для лабораторных работ по курсу 'Программирование и алгоритмизация' института НИТУ МИСИС.
double a, b, r, x, y;
int n, k;
Console.WriteLine("Введите a");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите r");
r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество точек");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
Console.WriteLine("Введите координаты точки по x");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки по y");
y = Convert.ToDouble(Console.ReadLine());
if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2)  <= r * r)
{
k++;
}
}
Console.WriteLine("В кругу будет находиться {0} точек из {1}", k, n);
