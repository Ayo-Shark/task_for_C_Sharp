using System.Runtime.InteropServices;

class Program
{

    static void Main()
    {
        Random random = new Random();
        int vvod;
        int id = 0;
        int index = 0;
        int car_count_in_park;
        int car_Count = 0;
        while (true)
        {
            Console.Write("Сколько машин в автопарке: ");
            if ((int.TryParse(Console.ReadLine(), out car_count_in_park)) && (car_count_in_park > 0))
            {
                break;
            }

            else
            {
                Console.WriteLine("Не тот формат");
            }
        }
        
        Avto[] car2 = new Avto[car_count_in_park];
        
       
        while (true)
        {
            Console.Write("Выберите команду:");
            Console.WriteLine("\n1.Добавить машину");
            Console.WriteLine("2.Заправить машину");
            Console.WriteLine("3.Ехать");
            Console.WriteLine("4.Авария");
            Console.WriteLine("5.Информация о всех машинах");
            Console.WriteLine("6.Остановиться");
            Console.WriteLine("7.Остаток топлива");
            Console.WriteLine("8.Информация о конкретной машине");
            Console.WriteLine("9.Положение машины");
            while (true)
            {
                Console.Write("Команда: ");
                if (int.TryParse(Console.ReadLine(), out vvod))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                
            }

            switch (vvod)
            {
                case 1:
                    Console.Clear();
                    if (index > car_count_in_park -1 )
                    {
                        Console.WriteLine("Да нельзя столько машин в автопарк");
                        break;

                    }
                    Console.Write("Марка машины: ");
                    string marka = Console.ReadLine();
                    Console.Write("Название машины: ");
                    string nom = Console.ReadLine();
                    float bak;
                    while (true)
                    {
                        Console.Write("Объем бака (л): ");
                        if ((float.TryParse(Console.ReadLine(), out bak) && bak > 0)) 
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не тот формат");
                        }
                    }
                   
                    float ras;
                    while (true)
                    {
                        Console.Write("Расход топлива (л/100км): ");
                        if ((float.TryParse(Console.ReadLine(), out ras)))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не тот формат");
                        }
                    }
                    
                    float bak_oil;
                    while (true)
                    {
                        Console.Write("Количество бензина в баке: ");
                        if ((float.TryParse(Console.ReadLine(), out bak_oil)) && (bak_oil <= bak && bak_oil >= 0))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не тот формат");
                        }
                    }

                        Avto car = new Avto();
                        car.info(marka, nom, bak, ras, bak_oil);
                        car2[index] = car;
                        car_Count++;
                        index++;
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                     //Console.Write("Введите id машины для заправки: ");
                     id = proverka(car_Count);
                    
                    float top;
                    while (true)
                    {
                        Console.Write("Количество топлива для заправки: ");
                        if ((float.TryParse(Console.ReadLine(), out top)))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не тот формат");
                        }
                    }
                    car2[id].zapravka(top);
                    //Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    //Console.Write("Введите id машины для поездки: ");
                    id = proverka(car_Count);
                    //car2[id].razgon();
                    car2[id].move();
                    //Console.Clear();
                    break;

                case 4:

                    /*if (car_Count < 2)
                    {
                        Console.WriteLine("Машин должно быть минимум 2 для аварии!");
                        break;
                    }*/
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }

                    int car_avaria = 0;
                    int car_avaria2 = 0;

                    if (car_Count > 1)
                    {
                        while (true)
                        {
                            car_avaria = random.Next(0, car_Count);
                            car_avaria2 = random.Next(0, car_Count);

                            if (car_avaria != car_avaria2 && car2[car_avaria] != null && car2[car_avaria2] != null)
                            {
                                break;
                            }
                        }

                        car2[car_avaria].avaria(car2[car_avaria2]);
                    }
                    else
                    {
                        Console.WriteLine("АААААААААА, МАШИНА УЛЕТЕЛА В КЮВЕТ");
                    } 
                    
                 

                    

                    break;

                   

                case 5:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    foreach (Avto avt in car2)
                    {
                        if (avt != null)
                        {
                            avt.Out();
                        }

                    }
                    break;

                case 6:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    //Console.Write("Введите id машины которая должна тормозить: ");
                    id = proverka(car_Count);
                    car2[id].tormoz();

                    break;

                case 7:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    id = proverka(car_Count);
                    car2[id].ostatok();  
                    break;
                case 8:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    //Console.Write("Введите id для вывода информации о машине; ");
                    id = proverka(car_Count);
                    car2[id].Out();
                    break;
                case 9:
                    Console.Clear();
                    if (car_Count == 0)
                    {
                        Console.WriteLine("Машин нет");
                        break;
                    }
                    //Console.Write("Введите id для вывода позиции машины: ");
                    id = proverka(car_Count);
                    car2[id].position();
                    break;
                   
                    
                default:
                    Console.WriteLine("Такой команды нет. Введите команду от 1 до 9");
                    break;
                   
            }
            


        }


    }
    static int proverka(int car_Count)
    {
        while (true)
        {
            Console.Write("Введите id машины: ");
            if (int.TryParse(Console.ReadLine(), out int id) && id >= 0 && id < car_Count)
            {
                return id;
            }
            else
            {
                Console.WriteLine("Неверный id");
            }
        }
    }
}

