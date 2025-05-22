
int N;
int random;
int random1;
while (true) 
{
    Console.WriteLine("Введите размерность матрицы");
    if ((int.TryParse(Console.ReadLine(), out N)) && (N > 0))
    {
        break;
    }
    else 
    {
        Console.WriteLine("Некорректный формат");
    }

}
while (true)
{
    Console.WriteLine("Введите диапозон чисел");
    if ((int.TryParse(Console.ReadLine(), out random)) && (int.TryParse(Console.ReadLine(), out random1)))
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректный формат");
    }
}
int[,] A = new int[N, N];
int[,] B = new int[N, N];
Random random2 = new Random();
Console.WriteLine("Первая матрица");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        A[i, j] = random2.Next(random, random1);
        Console.Write(A[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        B[i, j] = random2.Next(random, random1);
        Console.Write(B[i, j] + "\t");
    }
    Console.WriteLine();
}
while (true)

{
    int vvod;
    while (true)
    {

        Console.WriteLine("1) Сложить матрицы \n2) Вычитание A-B \n3) Вычитание В-А \n4) Выход из программы");
        if (int.TryParse(Console.ReadLine(), out vvod))
        {
            Console.Clear();
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            break;
        }
        else
        {
            Console.WriteLine("Некорректный формат");
        }
    }

    if (vvod == 1)
    {
        Console.WriteLine("Сложение матриц");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                
                Console.Write(A[i, j] + B[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    else if (vvod == 2)
    {
        Console.WriteLine("Вычитание A-B");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                
                Console.Write(A[i, j] - B[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
       else if (vvod == 3)
        {
            Console.WriteLine("Вычитание B-A");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    
                    Console.Write(B[i, j] - A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    else if (vvod == 4)
    {
        Console.Clear();
        break;
    }
    }
