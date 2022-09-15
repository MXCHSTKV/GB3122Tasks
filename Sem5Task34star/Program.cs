//========================================================================================
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Отсортируйте массив методом пузырька.
//========================================================================================

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

int length = ReadData("Задайте длину массива: ");

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Создание и заполнение массива элементами в заданном диапазоне
int[] CreateRandomArray(int leng)
{
    int[] array = new int[leng];
    Random rnd = new Random();

    for (int i = 0; i < leng; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

// Сортируем массив пузырьковым методом
int[] BubbleSort(int[] arr)
{
  int temp = 0;
  for(int i = 0; i < arr.Length-1; i++)
  {
    for(int j = 0; j < arr.Length -1 - i; j++)
    {
    if(arr[j + 1] < arr[j])
      {
        temp = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = temp;
      }
    }
  }
  return arr;
}

int[] array = CreateRandomArray(length);
Print1DArray(array);
PrintResult("После сортировки: ");
Print1DArray(BubbleSort(array));
