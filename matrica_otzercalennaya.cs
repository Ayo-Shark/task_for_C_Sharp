int N;
int random;
int random1;
int numberiki = 0;


    
        while (true)
        {
            Console.Write("Введите размерность матрицы");
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
            Console.WriteLine("Введите диапазон чисел");
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
        Console.WriteLine("Исходная матрица");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                A[i, j] = random2.Next(random, random1);
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Матрица с нулями");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                B[i, j] = A[i, j];
                if (j > numberiki)
                {
                    B[i, j] = 0;

                }
                Console.Write(B[i, j] + "\t");

            }
            numberiki++;
            Console.WriteLine();
        }

        Console.WriteLine("Отзеркаленная матрица");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(B[j, i] + "\t");
            }
            Console.WriteLine();
        }
    
   
