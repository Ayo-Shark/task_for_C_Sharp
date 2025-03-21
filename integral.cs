
using System.Diagnostics.CodeAnalysis;

double a;
double b;
int n;
while (true)
{
    Console.WriteLine("Введите а");
    if (double.TryParse(Console.ReadLine(), out a))
    {
        break;
    }
    else
    {
        Console.WriteLine("Буквы нельзя");
    }
}
while (true)
{
    Console.WriteLine("Введите b");
    if (double.TryParse(Console.ReadLine(), out b))
    {
        break;
    }
    else
    {
        Console.WriteLine("Буквы нельзя");
    }
}
while (true)
{
    Console.WriteLine("Введите n");
    if ((int.TryParse(Console.ReadLine(), out n)) && (n > 0))
    {
        break;
    }
    else
    {
        Console.WriteLine("Буквы нельзя");
    }
}
double sum = 0;
double sum_otvet = 0;
double resultat = 0; 
double x = 0;
double h = (b - a) / n;
for (int i = 1; i <= n; i++)
{
    resultat += a + i * h / 2;
    //Console.WriteLine(x);
    
    
}
x = h * resultat;
sum_otvet = 2 * Math.Pow(x, 2) + 3 * x;
Console.WriteLine(sum_otvet);