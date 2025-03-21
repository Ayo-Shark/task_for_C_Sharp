string znak_zod = "";
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Ваше имя?");
string name = Convert.ToString(value: Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Ваша фамилия?");
Console.WriteLine("-------------------------------------------------------------------------");
string last_name = Convert.ToString(value: Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("В какой день Вы родились?");
int data_birth = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (data_birth <= 31)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorect.Try again");
        data_birth = Convert.ToInt32(Console.ReadLine());
    }

}
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("В какой месяц Вы родились?");
int weekend_birth = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (weekend_birth <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorect.Try again");
        weekend_birth = Convert.ToInt32(Console.ReadLine());
    }

}
switch (weekend_birth)
{
    case 1:
        if (data_birth >= 1 && data_birth <= 19)
        {
            znak_zod = "Козерог";
        }


        if (data_birth >= 20 && data_birth <= 31)
        {
            znak_zod = "Водолей";
        }
        break;
       
    case 2:
        if (data_birth <= 18 && data_birth >= 1)
        {
            znak_zod = "Водолей";
        }

        if (data_birth >= 19 && data_birth <= 29)
        {
            znak_zod = "Рыбы";
        }
        if (data_birth >= 30)
        {
            znak_zod = "В феврале 29 дней";
        }
        break;
    case 3:
        if (data_birth >= 1 && data_birth <= 20)
        {
            znak_zod = "Рыбы";
        }


        if (data_birth >= 20 && data_birth <= 31)
        {
            znak_zod = "Овен";
        }
        break;
    case 4:
        if (data_birth >= 1 && data_birth <= 19)
        {
            znak_zod = "Овен";
        }


        if (data_birth >= 20 && data_birth <= 30)
        {
            znak_zod = "Телец";
        }
        break;
    case 5:
        if (data_birth >= 1 && data_birth <= 20)
        {
            znak_zod = "Телец";
        }


        if (data_birth >= 21 && data_birth <= 31)
        {
            znak_zod = "Близнецы";
        }
        break;

    case 6:
        if (data_birth >= 1 && data_birth <= 20)
        {
            znak_zod = "Близнецы";
        }


        if (data_birth >= 21 && data_birth <= 30)
        {
            znak_zod = "Рак";
        }
        break;

    case 7:
        if (data_birth >= 1 && data_birth <= 22)
        {
            znak_zod = "Рак";
        }


        if (data_birth >= 23 && data_birth <= 31)
        {
            znak_zod = "Лев";
        }
        break;
    case 8:
        if (data_birth >= 1 && data_birth <= 22)
        {
            znak_zod = "Лев";
        }


        if (data_birth >= 23 && data_birth <= 31)
        {
            znak_zod = "Дева";
        }
        break;
    case 9:
        if (data_birth >= 1 && data_birth <= 22)
        {
            znak_zod = "Дева";
        }


        if (data_birth >= 23 && data_birth <= 30)
        {
            znak_zod = "Весы";
        }
        break;
    case 10:
        if (data_birth >= 1 && data_birth <= 22)
        {
            znak_zod = "Весы";
        }


        if (data_birth >= 23 && data_birth <= 31)
        {
            znak_zod = "Скорпион";
        }
        break;
    case 11:
        if (data_birth >= 1 && data_birth <= 21)
        {
            znak_zod = "Скорпион";
        }


        if (data_birth >= 22 && data_birth <= 30)
        {
            znak_zod = "Стрелец";
        }
        break;
    case 12:
        if (data_birth >= 1 && data_birth <= 21)
        {
            znak_zod = "Стрелец";
        }


        if (data_birth >= 22 && data_birth <= 31)
        {
            znak_zod = "Козерог";
        }
        break;

    default:
        znak_zod = "Некоректные данные";
        break;
}
Console.WriteLine($"Ваше имя: {name}, Ваш фамилия: {last_name}, Ваш знак зодиака: {znak_zod}");
