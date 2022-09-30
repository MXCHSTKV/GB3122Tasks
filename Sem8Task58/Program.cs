//==========================================================
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
//==========================================================


// Чтение данных в консоли
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Печать результата
void PrintResult(string text)
{
    Console.WriteLine(text);
}

// Печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t ");
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

// умножение матриц
int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
    {
        throw new Exception("Матрицы нельзя перемножить");
    }
    int[,] multiplArray = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
                multiplArray[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
    return multiplArray;
}

int k = ReadData("Введите количество строк для 1-ой матрицы M: ");
int l = ReadData("Введите количество столбцов для 1-ой матрицы N: ");
int m = ReadData("Введите количество строк для 2-ой матрицы K: ");
int n = ReadData("Введите количество столбцов для 2-ой матрицы L: ");

int[,] firstMatrix = new int[k, l];
int[,] secondMatrix = new int[m, n];

Fill2DArray(firstMatrix, 1, 9);
PrintResult("--- Первая матрица ---");
Print2DArray(firstMatrix);
Fill2DArray(secondMatrix, 1, 9);
PrintResult("--- Вторая матрица ---");
Print2DArray(secondMatrix);

int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);
PrintResult("--- Произведение матриц ---");
Print2DArray(result);