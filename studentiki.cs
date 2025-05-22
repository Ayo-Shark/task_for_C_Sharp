using System;

double[,] mas = new double[5, 25];
double[] crednie_ball = new double[5];
double[] avg_ball_student = new double[25];
int count = 1;
double max_mark = double.MinValue;
double min_mark = double.MaxValue;
double max_mark_student = double.MinValue;
double min_mark_student = double.MaxValue;
int index_max = 0;
int index_min = 0;
int index_max_student = 0;  
int index_min_student = 0;
Random random2 = new Random();
Console.WriteLine("Оценки студентиков (они не готовились)");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 25; j++)
    {
        mas[i, j] = random2.Next(2, 6);
        
        Console.Write(mas[i, j] + " | ");
        crednie_ball[i] += mas[i, j];
        avg_ball_student[j] += mas[i, j];
        
    }
    Console.WriteLine();
    crednie_ball[i] /= 25;
   
}
/*foreach (double i in crednie_ball)
{
    if (i > max_mark)
    {
        max_mark = i;
    }
    if (i < min_mark)
    {
        min_mark = i;
    }
}
foreach (double i in avg_ball_student)
{
    if (i / 5 > max_mark_student)
    {
        max_mark_student = i / 5;
    }
    if (i / 5  < min_mark_student)
    {
        min_mark_student = i / 5;
    }

}*/
for (int i = 0;i < 5; i++)
{
    if (crednie_ball[i] > max_mark)
    {
        max_mark = crednie_ball[i];
        index_max = i + 1;
    }
    if (crednie_ball[i] < min_mark)
    {
        min_mark = crednie_ball[i];
        index_min = i + 1;
    }
}
for (int i = 0; i < 25; i++)
{
    if (avg_ball_student[i] / 5 > max_mark_student)
    {
        max_mark_student = avg_ball_student[i] / 5;
        index_max_student = i + 1;
    }
    if (avg_ball_student[i] / 5 < min_mark_student)
    {
        min_mark_student = avg_ball_student[i] / 5;
        index_min_student = i + 1;
    }
}
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine("Средние оценки");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine($"1.Мат.анализ: {crednie_ball[0]} \n2.Проектирование и защита баз данных: {crednie_ball[1]} \n3.Основы алгоритмизации и программирования: {crednie_ball[2]} \n4.Администрирование баз данных: {crednie_ball[3]} \n5.Дискретная математика с элементами логики: {crednie_ball[4]}");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine($"Максимальный средний балл: {max_mark} за предмет {index_max}");
Console.WriteLine($"Минимальный средний балл: {min_mark} за предмет {index_min}");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine("Средние оценки студентиков-неучей");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
for (int i = 0; i < 25; i++)
{
    
    Console.WriteLine($"Студент {count}: {avg_ball_student[i] / 5}");
    count++;
}
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine($"Максимальный средний балл: {max_mark_student} y {index_max_student}-ого студентика");
Console.WriteLine($"Минимальный средний балл: {min_mark_student} y {index_min_student}-ого студентика");
Console.WriteLine("---------------------------------------------------------------------------------------------------");