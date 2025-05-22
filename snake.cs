int n;
int num = 1;
while (true)
{
    Console.Write("Введите число: ");
    if ((int.TryParse(Console.ReadLine(), out n)) && n <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректный формат");
    }
}
int[,] snake = new int[n, n];

int dioganal = n * 2 - 1;

for (int d = 0; d < dioganal; d++)
{
    int start_num_row;
    int start_num_stolb;
    
    if (d < n)
    {
        start_num_row = d;
        start_num_stolb = 0;
    }
    else
    {
        start_num_row = n - 1;
        start_num_stolb = d - n + 1;
    }
    //int start_num_stolb;
    /*if (d < n) 
    {
        start_num_stolb = 0;
    }
    else
    {
        start_num_stolb = d - n + 1;
    }*/
    if (d % 2 == 0)
    {
        //int i = start_num_row;
        //int j = start_num_stolb;

        while (start_num_row >= 0 && start_num_stolb < n)
        {
            snake[start_num_stolb, start_num_row] = num++;
            start_num_row--;
            start_num_stolb++;
        }
    }
    else
    {
        //int i = start_num_stolb;
        //int j = start_num_row;

        while (start_num_stolb < n && start_num_row >= 0)
        {
            snake[start_num_row, start_num_stolb] = num++;
            start_num_stolb++;
            start_num_row--;
        }
    }
    }
Console.WriteLine("Змейка");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        //snake[i, j] = num;
        //num++;
        Console.Write(snake[i,j] + "\t");
    }
    Console.WriteLine();
}