//======================================================================
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//======================================================================

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

// Функция Аккермана
int A(int m, int n)
{
  if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
  if (n == 0 && m > 0) return A(m - 1, 1);
  if (m == 0) return n + 1;
  return A(m - 1, A(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

PrintResult(A(m, n));
