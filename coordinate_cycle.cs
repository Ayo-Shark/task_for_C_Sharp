
double x_first;
double y_first;
double v_first;
double ugol; 
double g = 9.81;
double t = 0;
double y = 0;
double x = 0;
//double max_y = 0;

while (true)
{
    Console.WriteLine("Введите начальные координаты x");
    if (double.TryParse(Console.ReadLine(), out x_first))
        
            { break; }
    else
    {
        Console.WriteLine("Только циферки...и буковки нельзя");

    }
}

while (true)
{
    Console.WriteLine("Введите начальные координаты y");
   
    if ((double.TryParse(Console.ReadLine(), out y_first)) && (y_first >= 0))
    { break; }
    if (y_first < 0)
    {
        Console.WriteLine("Только положительные циферки.. Введите еще раз ^-^ ");
        continue;
    }
    else
    {
        Console.WriteLine("Буковки нельзя, обрабатывать не умею :( ");
       
    }
}

while (true)
{
    Console.WriteLine("Введите начальную скорость");
    if ((double.TryParse(Console.ReadLine(), out v_first)) && (v_first >= 0))
    { break; }
    if (v_first < 0)
    {
        Console.WriteLine("Только положительная скорость");
        continue;
    }
    else
    {
        Console.WriteLine("Ай-яй, опять буквы ввели.. :( ");

    }
}

while (true)
{
    Console.WriteLine("Введите угол вылета снаряда (в градусах)");
    if (((double.TryParse(Console.ReadLine(), out ugol)) && (ugol >= 0)) && (ugol <= 360))
    {
        if (y_first == 0)
        {
            if ((ugol > 180) || (ugol < 0))
            {
                Console.WriteLine("у = 0. Угол может быть от 0 до 180");
                continue;
            }
        }
        break;
    }
    if ((ugol < 0) || (ugol > 360))
    {
        Console.WriteLine("Только положительные циферки от 0 до 360, мяу");
        continue;
    }
    else
    {
        Console.WriteLine("Буковки нельзя, их считать нельзя :( ");

    }
}


double ugol_radean = ugol * Math.PI / 180;
Console.WriteLine("--------------------------------");
Console.WriteLine($"      x        |       y      ");
Console.WriteLine("--------------------------------");
while (true)
{   if (y >= 0)
    {
        //double v_zero = Math.Floor(v_first * Math.Sin(ugol_radean));
        y = y_first + (v_first * Math.Sin(ugol_radean)) * t - (g * Math.Pow(t, 2) / 2);
        //double v_zero_x = Math.Floor(v_first * Math.Cos(ugol_radean));
        x = x_first + (v_first * Math.Cos(ugol_radean)) * t;
       
        
    }
   if (y < 0)
    {
        break;
    }
    Console.WriteLine($"    {x:F2}             {y:F2}");
    t += 0.1;

}
Console.WriteLine("Расчет окончен");

