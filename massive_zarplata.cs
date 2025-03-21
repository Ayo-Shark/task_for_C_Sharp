using Microsoft.VisualBasic;

double[] arr = new double[12];
int month = 1;
int mouth_min = 1;
int mouth_max = 1;
double min = double.MaxValue;
double max = double.MinValue;
double arr_fond = 0;
double summa = 0;
double summa_fond = 0;
Random random = new Random();


for (int i = 0; i < 12; i++)
{
    arr[i] = random.Next(1000, 5000);
    summa += arr[i];
   
    if (arr[i] < min)
    {
        min = arr[i];
        mouth_min = i + 1;
    }
    if (arr[i] > max)
    {
        max = arr[i];
        mouth_max = i + 1;
    }

}
for (int i = 0; i < 12; i++, month++)
{
    arr_fond = arr[i] / 100 * 2;
    Console.WriteLine($"Зарплата за {month} месяц составила {arr[i]} долларов. Отчисление пенсионному фонду {arr_fond}. Отклонение {Math.Abs(summa / 12 - arr[i]):F2} ");
    summa_fond += arr_fond;
}

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine($"Зарплата за весь год составила: {summa} долларов");
Console.WriteLine($"Каждый месяц сотрудник получал в среднем: {summa / 12:F2} долларов");
Console.WriteLine($"Минимальная зарплата за рабочий год {min} за {mouth_min}, максимальная зарплата за рабочий год {max} за {mouth_max}");
Console.WriteLine($"Годовые отчисления в фонд {summa_fond:F2}");
