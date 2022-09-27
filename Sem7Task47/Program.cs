// -------------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
// -------------------------------------------------------------------------------------

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Создание списка цветов терминала
ConsoleColor[] color = new ConsoleColor[]{ConsoleColor.Red,ConsoleColor.DarkRed,ConsoleColor.Yellow,
                                        ConsoleColor.DarkYellow,ConsoleColor.Green,ConsoleColor.DarkGreen,
                                        ConsoleColor.Blue,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,
                                        ConsoleColor.Magenta,ConsoleColor.DarkMagenta,ConsoleColor.White,
                                        ConsoleColor.Gray,ConsoleColor.DarkGray,ConsoleColor.Black,ConsoleColor.Cyan};

// Печать двумерного массива
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string number = matrix[i, j].ToString("0.00");

            for (int k = 0; k < number.Length; k++)
            {
                Console.ForegroundColor = color[new System.Random().Next(0, 16)];
                Console.Write(number[k]);
                Console.ResetColor();
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// Заполняем массив случайными вещественными числами
void Fill2DArrayDouble(double[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * max - min, 2);
        }
    }
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
double[,] matrix = new double[m, n];

Fill2DArrayDouble(matrix, 0, 15);
Print2DArray(matrix);