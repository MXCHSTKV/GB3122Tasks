//==============================================================
// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.
//==============================================================

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

int length = ReadData("Задайте длину массива: ");

// Создание и заполнение массива вещественными числами
double[] CreateRandomArray(int leng)
{
    double[] array = new double[leng];
    Random rnd = new Random();

    for (int i = 0; i < leng; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * rnd.Next(-1000, 1000)), 2);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(double[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

// Возвращает массив из минимального и максимального чисел массива-аргумента
double[] FindMinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double[] minMaxArray = new double[2];
    for (int i = 1; i < arr.Length; i++)
    {
      if(arr[i]>max)
      {
        max = arr[i];
      }
      if(arr[i]<min)
      {
        min = arr[i];
      }
    }
    minMaxArray[0] = min;
    minMaxArray[1] = max;

    return minMaxArray;
}

double[] array = CreateRandomArray(length);

// Находим разницу между максимальным и минимальным элементами массива
double differ = Math.Round(FindMinMax(array)[1] - FindMinMax(array)[0], 2);

Print1DArray(array);
PrintResult($"Разница между максимальным и минимальным элементами: {differ}");