// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

// Пока не получилось сделать непвторяющиеся числа =(

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите количество элементов для 1-го измерения: ");
    int izmerenie1 = int.Parse(Console.ReadLine());

    Console.Write("Введите количество элементов для 2-го измерения: ");
    int izmerenie2 = int.Parse(Console.ReadLine());

    Console.Write("Введите количество элементов для 3-го измерения: ");
    int izmerenie3 = int.Parse(Console.ReadLine());

    Console.WriteLine();
    int[,,] arr = GetArray(izmerenie1, izmerenie2, izmerenie3);
    PrintArray(arr);

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

int[,,] GetArray(int izm1, int izm2, int izm3)
{
    int[,,] array = new int[izm1, izm2, izm3];
    Random newRnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = newRnd.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент массива с индексом {i}, {j}, {k} = {array[i, j, k]}");
            }
        }
    }
}

bool CheckNum(int[,,] array, int num)
{
    bool check = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (num == array[i, j, k]) 
                {
                    check = true;
                    break;
                }
            }
        }
    }
    return check;
}
