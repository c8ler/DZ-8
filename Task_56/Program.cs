// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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
    int minStroka = FindMinStr(arr) + 1;
    Console.WriteLine($"Строка, с наименьшей суммой элементов в массиве = {minStroka} (в обычном человеческом представлении).");

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

int FindSumInRow(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[row, i];
        }
    return sum;
}

int FindMinStr(int[,] array)
{
    int minStr = 0;
    int sum = 99999999; // просто большое число
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (FindSumInRow(array, i) < sum)
        {
            minStr = i;
            sum = FindSumInRow(array, i);
        }
    }
    return minStr;
}
