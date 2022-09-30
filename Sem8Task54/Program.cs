//====================================================================
// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
//====================================================================


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

// Упорядочивание двумерного массива
int[,] Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Row.Add(array[i, j]);
            Row.Sort(); //сортировка по возрастанию
            Row.Reverse(); //сортировка по убыванию
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Row[j];
        }
    }
    return array;
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] array = new int[m, n];


Fill2DArray(array, 1, 9);
Console.WriteLine("--- Исходный массив ---");

Print2DArray(array);

Sort2DArray(array);
Console.WriteLine("--- Отсортированный массив ---");
Print2DArray(array);