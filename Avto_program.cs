using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Avto
{
    //private List<Avto> avto = new List<Avto>(); 
    Random rnd = new Random();
    private string? marka_m;
    private string? num_avto;
    private float bak_in_bak;
    private float oil_avto;
    private float rashod_topliva;
    private double start_x = 0, start_y = 0;
    private double end_x, end_y;
    private int speed;
    private int speed_now;
    private double probeg;
    // private int km;
   // private bool crash;
    public void stop()
    {
        speed = 0;
        Console.WriteLine("Машина остнановилась..");
    }
    //Avto car = new Avto("BMW", "508DK", 55, 7, 123);

    public void info(string marka, string nom, float bak, float ras, float bak_oil)
    {
        num_avto = nom;
        marka_m = marka;
        oil_avto = bak;
        rashod_topliva = ras;
        bak_in_bak = bak_oil;
        probeg = 0;
        start_x = 0;
        start_y = 0;

    }

    public Avto(string? marka_m = "", string? num_avto = "", float bak_in_bak = 0, float oil_avto = 0, float rashod_topliva = 0)//, int probeg)
    {
        //this.rnd = rnd;
        this.num_avto = num_avto;
        this.marka_m = marka_m;
        this.bak_in_bak = bak_in_bak;
        this.oil_avto = oil_avto;
        this.rashod_topliva = rashod_topliva;
        //this.probeg = probeg;

    }

    public void Out()
    {

        Console.WriteLine($"Марка машины: {marka_m}");
        Console.WriteLine($"Номер машины: {num_avto}");
        Console.WriteLine($"Объем бака: {oil_avto}");
        Console.WriteLine($"Расход топлива: {rashod_topliva:F2}");
        Console.WriteLine($"Количество топлива в баке: {bak_in_bak:F2}");
        Console.WriteLine($"Пробег: {probeg:F2}\n");
        position();
    }
    public void zapravka(float top)
    {
        if (bak_in_bak + top <= oil_avto)
        {
            
            bak_in_bak += Math.Abs(top);
            if (Math.Abs(top) + bak_in_bak > oil_avto && top < 0)
            {
                bak_in_bak = oil_avto;
                Console.WriteLine($"Нельзя отрицательное.. но ладно, возьму модуль.. И перелив мо модулю нельзя.. Аусть в баке максимальное количество топлива: {bak_in_bak}");
            }
            else
            {
                Console.WriteLine($"В бак добавилось {Math.Abs(top)}. В баке теперь: {bak_in_bak}");
            }
            
        }
        else
        {
            //Console.WriteLine("Бак заполнен полностью");
            bak_in_bak = oil_avto;
            Console.WriteLine($"Перелив. Но бак заполнен, а излишки убраны. Количество топлива {bak_in_bak}");
        }
       

    }

    private double distance()
    {
        double dist = Math.Sqrt(Math.Pow(end_x - start_x, 2) + Math.Pow(end_y - start_y, 2));
        return dist;
    }



    public void move()
    {


        while (true)
        {
            Console.Write("Введите конечную точку x: ");
            if (double.TryParse(Console.ReadLine(), out end_x))
            {

                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }


        while (true)
        {
            Console.Write("Введите конечную точку y: ");
            if (double.TryParse(Console.ReadLine(), out end_y))
            {

                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }


        double dist = distance();


        
        Console.WriteLine($"До цели: {dist:F2} км.");

        while (dist > 0)
        {
            double toplivo_nado = rashod_topliva * dist / 100;
            double max_dist = (bak_in_bak / rashod_topliva) * 100;

            if (max_dist >= dist)
            {
                bak_in_bak -= (float)toplivo_nado;
                probeg += dist;
                start_x = end_x;
                start_y = end_y;

                speed_now = rnd.Next(15, 150);
                razgon();
                Console.WriteLine($"Машина едет со скоростью {speed_now} км/ч");
                Console.WriteLine($"Проехали {dist:F2} км. Осталось топлива: {bak_in_bak:F2} л. Общий пробег: {probeg:F2} км");
                position();
                break;
            }
            else
            {
                Console.WriteLine($"Топлива хватит только на {max_dist:F2} км");
                probeg += max_dist;
                bak_in_bak = 0;

                dist -= max_dist;
                double distance_ostatok = dist;
                double toplivo_nado_dist_2 = rashod_topliva * distance_ostatok / 100;
                double pobraschet = max_dist / dist;
                start_x = start_x + (end_x - start_x) * pobraschet;
                start_y = start_y + (end_y - start_y) * pobraschet;
                

                Console.WriteLine($"Проехали {max_dist:F2} км. Бак пуст. Осталось проехать {dist:F2} км. Общий пробег: {probeg:F2} км");
                //bool vopros;
                int vvod_vopros;
                while (true)
                {
                    Console.WriteLine($"Не доедем... Нужно {toplivo_nado_dist_2:F2} л. Заправиться?\n1.Да\n2.Нет");
                    Console.Write("Введите номер ответа: ");
                    if ((int.TryParse(Console.ReadLine(), out vvod_vopros)) && (vvod_vopros != 1 || vvod_vopros != 2))
                        break;
                    else
                        Console.WriteLine("Не тот формат");
                }

                if (vvod_vopros == 1)
                {
                    while (true)
                    {
                        float top;
                        Console.Write("Введите количество топлива для заправки: ");
                        if (float.TryParse(Console.ReadLine(), out top))
                        {
                            zapravka(top);
                            Console.WriteLine($"Топливо после заправки: {bak_in_bak:F2} л");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не тот формат");
                        }
                    }
                }
                if (vvod_vopros == 2)
                {
                    Console.WriteLine("Машина никуда не поедет");
                    stop();
                    break;
                }
            }
        }
    }

    public void ostatok()
    {

        Console.WriteLine($"В баке: {bak_in_bak:F2}");
        if (bak_in_bak <= 0)
        {
            bak_in_bak = 0;
        }
        
    }

    public void razgon()
    {
        while (speed < speed_now)
        {
            
            speed = speed + 5;
            Console.WriteLine($"Машина разгоняется: {speed}");
            Thread.Sleep(200);
        }
    }

    public void tormoz()
    {
        while (speed >= 5)
        {
            speed = speed - 5;
            Console.WriteLine($"Машина снижает скорость: {speed}");
            Thread.Sleep(200);
        }
        stop();
        
    }

    public void avaria(Avto car)
    {
        Console.WriteLine($"Машина под номером {num_avto} врезалась в машину {car.num_avto}");
        stop();
    }

    public void position()
    {
        Console.WriteLine($"Положение машины: ({start_x:F2}; {start_y:F2})");
    }




}