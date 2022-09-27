// --------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет
// ---------------------------------------------------------------------

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Заполнение массива случайными числами
int[,] Fill2DArray(int row, int column, int min, int max)
{
    int[,] array2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(min, max + 1);
        }
    }
      return  array2D;
}

// Печать двумерного массива
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

// Поиск элемента
int FindElement(int y, int x, int[,] array2D)
{
    if (y < array2D.GetLength(0) && x < array2D.GetLength(1))
    {
        return array2D[y, x] ; // y = строка; х = столбец
    }
    else
    {
        return -1;
    }
}

// Вывод результата
void PrintResult(int y, int x, int[,] array2D)
{
    if (y < array2D.GetLength(0) && x <  array2D.GetLength(1))
    {
        Console.WriteLine($"Значение элемента {array2D[y, x]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}



int row = ReadData("Введите число строк m: ");
int column = ReadData("Введите число столбцов n: ");
int[,] array = Fill2DArray(row, column, 1, 99);
Print2DArray(array);
int y = ReadData("Координата элемента в строке m: ") - 1;
int x = ReadData("Координата элемента в столбце n: ") -1;
int element = FindElement(y, x, array);
PrintResult(y, x, array);
