//Console.WriteLine("Введите число");
int number;

while (true)
{
    Console.WriteLine("Введите число");
    string not_num = Convert.ToString(Console.ReadLine());

    if (int.TryParse(not_num, out number))
    {
        break; 
    }
    else
    {
        Console.WriteLine("Хватит ломать программу, ну пожалуйста... Только циферки...");
        
    }
}


if (number < 0)
{
    Console.WriteLine("А я вот не знаю, что с отрицательным числом делать...Может, оно положительное?");
    number = Math.Abs(number);
    Console.WriteLine(number);
}

int num_proverka = number;



Console.WriteLine("Введите основание системы счисления");
int num_system = Convert.ToInt32(Console.ReadLine());
while (num_system < 2 || num_system > 16)
{
    Console.WriteLine("Введите основания системы счисления от 2 до 9");
    num_system = Convert.ToInt32(Console.ReadLine());
}

while (num_proverka > 0)
{
    int for_num = num_proverka % 10;
    if (for_num >= num_system)
    {
        Console.WriteLine("Такого числа в этой системе счисления не может быть");
        Console.WriteLine("Введите корректное число");
        number = Convert.ToInt32(Console.ReadLine());
        num_proverka = number;
    }
    else
    {
        num_proverka = num_proverka / 10;
    }
}



Console.WriteLine("В какую систему перевести?");

int why_num = Convert.ToInt32(Console.ReadLine());
while (why_num < 2 || why_num > 10)
{
    Console.WriteLine("Введите систему счисления от 2 до 16");
    why_num = Convert.ToInt32(Console.ReadLine());
}


string len = number.ToString();
int last_num = 0;
double last_answer = 0;
double sum = 0;
double answer = 0;
double originalNumber = number;
double total_sum = 0;
string result = "";

if (why_num == 10)
{
    for (int i = 0; i < len.Length; i++)
    {

        {
            answer = number % 10 * Math.Pow(num_system, i);
            last_num = number / 10;
            number = last_num;
            last_answer = answer;
            sum += last_answer;
        }
    }
    Console.WriteLine($"Число {originalNumber} в {num_system}-ой системе счисления равняется числу {sum} в десячичной системе счисления");
}

else if (why_num < 10 && why_num >= 2)
{
    for (int i = 0; i < len.Length; i++)
    {
        answer = number % 10 * Math.Pow(num_system, i);
        last_num = number / 10;
        number = last_num;
        last_answer = answer;
        sum += last_answer;
    }
    {
        double other_sum = sum;
        while (other_sum > 0)
        {
            total_sum = Math.Floor(other_sum % why_num);
            result = total_sum.ToString() + result;
            other_sum = Math.Floor(other_sum / why_num);
        }

    }
    Console.WriteLine($"Число {originalNumber} в {num_system}-ой системе счисления равняется числу {result} в {why_num}-ой системе счисления");
}











