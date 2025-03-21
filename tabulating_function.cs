double min_value = double.PositiveInfinity; //я загуглила, как используется бесконечность в с#, так как здесь это необходимо для поиска min и max числа//
double max_value = -double.PositiveInfinity; //я могла бы использовать просто большое число, но с бесконечностью программа будет работать не в рамках определенных чисел// 
double switch_znak = 0;
double last_y = 0;
double count_tochek = 0; 
double min_y = 0;
double max_y = 0;
Console.WriteLine("Введите начало координат а");
double a = Convert.ToDouble(Console.ReadLine());
Console. WriteLine("Введите начало координат b");
double b = Convert.ToDouble(Console.ReadLine());
while (true)
    if (b > a)
    {
        break;
    }
    else
    {
        Console.WriteLine("b не может быть меньше a. Введите еще раз b");
        b = Convert.ToDouble(Console.ReadLine());
    }
Console.WriteLine("Введите шаг h");
double h = Convert.ToDouble(Console.ReadLine());
while (true)
    if (h != 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Шаг не должен равнять нулю. Послушайте инструкции и введите снова шаг");
        h = Convert.ToDouble(Console.ReadLine());
    }
Console.Clear();
Console.WriteLine($"При координатах отрезка [{a};{b}] и шагом {h} ");

Console.WriteLine("\n     Таблица значений     ");
Console.WriteLine("---------------------------------");
Console.WriteLine("        x        |       x(y)   ");



while (true) { 
for (double x = a; x <= b; x += h)
{
    double y = Math.Round(Math.Cos(x * x) + (Math.Sin(x) * Math.Sin(x)),2); 
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"       {Math.Round(x,2)}        |       {y}       ");  
   //Console.WriteLine($"При x = {x}, y = {y}");
        {
            { min_y = y; }
        if (min_y < min_value) 
        { min_value = min_y; }
            { max_y = y; }
            if (max_y > max_value)
        { max_value = max_y; }
            

        }
        { 
            if ((last_y < 0 && y > 0) || (last_y > 0 && y < 0))
            { switch_znak++; }
            last_y = y;
        }

        {
            
            { count_tochek++; }
        }
    
}
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Максимальное число = {max_value}, минимальное число = {min_value}");
    Console.WriteLine($"Знаков изменено = {switch_znak}");
    Console.WriteLine($"Количество точек = {count_tochek}");
    
    break;
    
}

