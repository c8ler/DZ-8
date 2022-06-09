// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника.

bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите размерность трегульника Паскаля: ");
    int izmer = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

int[,] GetArray(int izm)
{
    int[,] array = new int[izm, izm];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = newRnd.Next(0, 10);
        }
    }
    return array;
}