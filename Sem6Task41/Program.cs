// ------------------------------------------------------
// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// ------------------------------------------------------

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

// Считаем положительные числа
int Counter(int n)
{
    int res = 0;
    for (int i = 0; i < n; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }

    return res;
}

PrintResult($"Чисел больше нуля: {Counter(ReadData("Введите количество чисел: "))}");