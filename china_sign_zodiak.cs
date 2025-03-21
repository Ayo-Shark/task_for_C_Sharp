using System.Xml.Linq;

Console.WriteLine("Ваш год рождения?");
int year = Convert.ToInt32(Console.ReadLine());
int year1 = year % 10;
int year_zodiac = year % 12;
string your_znak = "";
string f_your = "";
while (true)
    if (year <= 2050 && year >= 0)
    {
        year1 = year % 10;
        year_zodiac = year % 12;
        break;
    }
    else
    {
        Console.WriteLine("А вам зачем такой год? Введите другой год");
        year = Convert.ToInt32(Console.ReadLine());

    }
switch (year1)
{
    case 0:
        {
            f_your = "Металл";
            break;
        }
    case 1:
        {
            f_your = "Металл";
            break;
        }
    case 2:
        {
            f_your = "Вода";
            break;
        }
    case 3:
        {
            f_your = "Вода";
            break;
        }
    case 4:
        {
            f_your = "Дерево";
            break;
        }
    case 5:
        {
            f_your = "Дерево";
            break;
        }
    case 6:
        {
            f_your = "Огонь";
            break;
        }
    case 7:
        {
            f_your = "Огонь";
            break;
        }
        case 8:
        {
            f_your = "Земля";
            break;
        }
        case 9:
        {
            f_your = "Земля";
            break;
        }
}

switch (year_zodiac)
{
    case 0:
        {
            your_znak = "Обезьяна";
        }
    break;
    case 1: {
            your_znak = "Петух";
        }
        break;
        case 2: {
            your_znak = "Собака";
        }
        break;
        case 3: {
            your_znak = "Свинья";
        }
        break;
        case 4: {
            your_znak = "Крыса";
        }
        break;
        case 5: {
            your_znak = "Бык";
        }
        break;
        case 6:
        {
            your_znak = "Тигр";
        }
        break;
        case 7: {
            your_znak = "Кролик";
        }
        break;
        case 8: {
            your_znak = "Дракон";
        }
        break;
        case 9:
        {
            your_znak = "Змея";
        }
        break;
        case 10:
        {
            your_znak = "Лошадь";
        }
        break;
        case 11:
        {
            your_znak = "Коза";
        }
        break;
}


Console.WriteLine($"Ваше знак: {your_znak}. Ваша стихия: {f_your}"); 