using System.ComponentModel.Design;

Random rnd = new Random();
int programm_number = rnd.Next(1, 101);
//Console.WriteLine(programm_number);
Console.WriteLine("Угадайте задуманное число от 1 до 100. У вас пять попыток.");
int user_number = Convert.ToInt32(Console.ReadLine());
    while (true)
    {
        if (user_number >= 1 && user_number <= 100) //я решила сделать проверку чисел через циклы. Сама программа работает по условиям. Они тут везде, но без них программа тоже будет работать. Это просто проверка на числа. 
        {
    
            break;
        }
        else
        {
            Console.WriteLine("Так нельзя. Прочитайте условия еще раз. Пожалуйста");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    }

    if (user_number != programm_number) 
    {
        Console.WriteLine("Неверно! Попробуйте еще раз. У вас остались 4 попытки");
        user_number = Convert.ToInt32(Console.ReadLine());

    }
    while (true)
    {
        if (user_number >= 1 && user_number <= 100)
        {

            break;
        }
        else
        {
            Console.WriteLine("Так нельзя. Прочитайте условия еще раз. Пожалуйста");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (user_number != programm_number)
        {
            Console.WriteLine("Неверно! Попробуйте еще раз. У вас остались 3 попытки");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    while (true)
    {
        if (user_number >= 1 && user_number <= 100) 
        {

            break;
        }
        else
        {
            Console.WriteLine("Так нельзя. Прочитайте условия еще раз. Пожалуйста");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (user_number != programm_number)
        {
            Console.WriteLine("Неверно! Попробуйте еще раз. У вас остались 2 попытки");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    while (true)
    {
        if (user_number >= 1 && user_number <= 100) 
        {

            break;
        }
        else
        {
            Console.WriteLine("Так нельзя. Прочитайте условия еще раз. Пожалуйста");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (user_number != programm_number)
        {
            Console.WriteLine("Неверно! Попробуйте еще раз. У вас осталась 1 попытка");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
    while (true)
    {
        if (user_number >= 1 && user_number <= 100) 

            break;
    
        else
        {
            Console.WriteLine("Так нельзя. Прочитайте условия еще раз. Пожалуйста");
            user_number = Convert.ToInt32(Console.ReadLine());
        }
}
    if (user_number != programm_number)
        {
            Console.WriteLine($"Неверно! У вас не осталось попыток. Заданное число: {programm_number}. Вы не экстрасенс :(");
        }
        else
        {
            Console.WriteLine("Верно! Вы прошли вступительные испытания для экстрасенсов :)");
        }
