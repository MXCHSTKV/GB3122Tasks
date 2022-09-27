// ---------------------------------------------------------------------
// Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// ---------------------------------------------------------------------


// Получение данных от пользователя и преобразование в число
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

// Находим среднее арифметическое по столбцам
double[] Count(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = arr[j] + matr[i, j];
        }
    }

    FindAverage(arr, matr.GetLength(0));
    return arr;
}

// Находим среднее арифметическое
double[] FindAverage(double[] arr, int numbers)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = Math.Round(arr[k] / numbers, 2);
    }
    return arr;
}

// печатаем массив
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int m = ReadData("Введите количество столбцов M: ");
int n = ReadData("Введите количество строк N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

PrintArray(Count(matrix));
