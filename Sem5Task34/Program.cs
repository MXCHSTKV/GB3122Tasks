//========================================================================================
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//========================================================================================

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
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

// считаем числа в массиве
int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateRandomArray(length);
Print1DArray(array);
PrintResult($"Количество четных чисел в массиве: {CountEvenNumbers(array)}");
