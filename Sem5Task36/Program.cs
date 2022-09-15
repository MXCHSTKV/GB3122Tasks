//========================================================================
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//========================================================================

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

// Создание и заполнение массива элементами в заданном диапазоне
int[] CreateRandomArray(int leng)
{
    int[] array = new int[leng];
    Random rnd = new Random();

    for (int i = 0; i < leng; i++)
    {
        array[i] = rnd.Next(0, 1000);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

// Сумма элементов на нечетных позициях
int CountOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
      sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateRandomArray(length);
Print1DArray(array);
PrintResult($"Сумма элементов на нечетных позициях: {CountOddElements(array)}");
