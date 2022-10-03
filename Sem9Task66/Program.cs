//===================================================================
// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
//===================================================================

// Чтение данных в консоли
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Вывод результата в консоль
void PrintResult(int data)
{
    Console.WriteLine(data);
}

// Рекурсивно выводит числа от N до 1
int RecGetNumbers(int N)
{
  return N == 1 ? N : N + RecGetNumbers(N-1);
}

PrintResult(RecGetNumbers(ReadData("Введите число N: ")));