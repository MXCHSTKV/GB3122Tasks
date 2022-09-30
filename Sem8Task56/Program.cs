//==================================================================
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//==================================================================

// Чтение данных в консоли
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Заполнение массива случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

 // Поиск строки с минимальной суммой чисел
int FindRowMinSum(int[,] array)
{
    int indexRowMinSum = -1;
    int minSum = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    if (minSum > sum)
    {
        minSum = sum;
        indexRowMinSum = i+1;
    }
  sum = 0;
    }
    return indexRowMinSum;
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
Console.WriteLine();
int[,] array = new int[m, n];

Fill2DArray(array, 1, 9);
Print2DArray(array);

Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в строке: {FindRowMinSum(array)}");