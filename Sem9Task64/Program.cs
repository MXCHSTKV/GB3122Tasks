//================================================================================
// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
//================================================================================

// Чтение данных в консоли
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

// Рекурсивно выводит числа от N до 1
string RecGetNumbers(int N)
{
  return N == 1 ? N.ToString() : $"{N} {RecGetNumbers(N-1)}";
}

PrintResult(RecGetNumbers(ReadData("Введите число N: ")));