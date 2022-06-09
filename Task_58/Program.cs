/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите количество строк массива 1: ");
    int rows1 = int.Parse(Console.ReadLine());

    Console.Write("Введите количество колонок массива 1: ");
    int cols1 = int.Parse(Console.ReadLine());

    int[,] arr1 = GetArray(rows1, cols1);
    PrintArray(arr1);
    Console.WriteLine();

    Console.Write("Введите количество строк массива 2: ");
    int rows2 = int.Parse(Console.ReadLine());

    Console.Write("Введите количество колонок массива 2: ");
    int cols2 = int.Parse(Console.ReadLine());

    int[,] arr2 = GetArray(rows2, cols2);
    PrintArray(arr2);
    Console.WriteLine();

    if (CheckSize(arr1, arr2))
    {
        PrintArray(MultiplyArr(arr1, arr2));
    }
    else
    {
        Console.WriteLine("Массивы не совпадают по размеру!");
    }
    
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

bool CheckSize(int[,] array1, int[,] array2)
{
    bool check = false;
    if (array1.GetLength(0) == array2.GetLength(0) 
        && array1.GetLength(1) == array2.GetLength(1))
        {
            check = true;
        }
    return check;
}

int[,] MultiplyArr(int[,] array1, int[,] array2)
{
    int[,] newArr = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return newArr;
}