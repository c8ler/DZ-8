// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество колонок массива: ");
    int cols = int.Parse(Console.ReadLine());

    int[,] arr = GetArray(rows, cols);
    PrintArray(arr);
    Console.WriteLine();
    SortArr(arr);
    PrintArray(arr);

    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random newRnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = newRnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArr(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1)- 1; k++)
            {
                if (array[j, k + 1] > array[j, k])
                {
                    temp = array[j, k];
                    array[j, k] = array[j, k + 1];
                    array[j, k + 1] = temp;
                }
            }
        }
    }
    return array;
}