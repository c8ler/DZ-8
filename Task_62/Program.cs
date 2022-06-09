// Задача 62: Заполните спирально массив 4 на 4.

// подглядел решение в интернете, сам конечно бы не додумался =(

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите размер квадратной матрицы: ");
    int izmerenie1 = int.Parse(Console.ReadLine());

    int izmerenie2 = izmerenie1;

    Console.WriteLine();
    int[,] arr = GetArray(izmerenie1, izmerenie2);
    PrintArray(arr);

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

int[,] GetArray(int izm1, int izm2)
{
    int[,] array = new int[izm1, izm2];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = izm1;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = izm1 * (dirChanges % 2) + izm2 * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                if (array[i, j] < 10)
                {
                    Console.Write(" " + array[i, j] + " ");
                }
                else Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}