string znak_zod = "";
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Ваше имя?");
string name = Convert.ToString(value: Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Ваша фамилия?");
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

if ((((data_birth >= 21 && data_birth <= 31) && (weekend_birth == 3))) || ((data_birth <= 19) && (weekend_birth == 4)))
{
    znak_zod = "Овен";
}


else if ((((data_birth >= 20 && data_birth <= 30) && (weekend_birth == 4))) || ((data_birth <= 20) && (weekend_birth == 5)))
{
    znak_zod = "Телец";
}

else if ((((data_birth >= 21 && data_birth <= 31) && (weekend_birth == 5))) || ((data_birth <= 20) && (weekend_birth == 6)))
{
    znak_zod = "Близнецы";
}

else if ((((data_birth >= 21 && data_birth <= 30) && (weekend_birth == 6))) || ((data_birth <= 22) && (weekend_birth == 7)))
{
    znak_zod = "Рак";

}

else if ((((data_birth >= 23 && data_birth <= 31) && (weekend_birth == 7))) || ((data_birth <= 22) && (weekend_birth == 8)))
{
    znak_zod = "Лев";

}

else if ((((data_birth >= 23 && data_birth <= 30) && (weekend_birth == 8))) || ((data_birth <= 22) && (weekend_birth == 9)))
{
    znak_zod = "Дева";
}

else if ((((data_birth >= 23 && data_birth <= 31) && (weekend_birth == 9))) || ((data_birth <= 22) && (weekend_birth == 10)))
{
    znak_zod = "Весы";
}

else if ((((data_birth >= 23 && data_birth <= 30) && (weekend_birth == 10))) || ((data_birth <= 21) && (weekend_birth == 11)))
{
    znak_zod = "Скорпион";
}

else if ((((data_birth >= 22 && data_birth <= 31) && (weekend_birth == 11))) || ((data_birth <= 21) && (weekend_birth == 12)))
{
    znak_zod = "Стрелец";
}

else if ((((data_birth >= 22 && data_birth <= 30) && (weekend_birth == 12))) || ((data_birth <= 19) && (weekend_birth == 1)))
{
    znak_zod = "Козерог";
}

else if ((((data_birth >= 20 && data_birth <= 31) && (weekend_birth == 1))) || ((data_birth <= 18) && (weekend_birth == 2)))
{
    znak_zod = "Водолей";
}

else if ((((data_birth >= 19 && data_birth <= 29) && (weekend_birth == 2))) || ((data_birth <= 20) && (weekend_birth == 3)))
{
    znak_zod = "Рыбы";
}
else if ((data_birth == 30 && weekend_birth == 2) || (data_birth == 31 && weekend_birth == 2))
{ znak_zod = "В феврале 29 дней ("; }

else
{ znak_zod = "Несуществующий"; }

Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine($"Ваше имя: {name}, Ваш фамилия: {last_name}, Ваш знак зодиака: {znak_zod}");
Console.WriteLine("-------------------------------------------------------------------------");

