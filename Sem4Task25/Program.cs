//=============================================================
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//=============================================================

// Math.Pow() работает существенно быстрее

//Получаем данные от пользователя
int ReadNumber(string text)
{
  Console.Write(text);
  int res = int.Parse(Console.ReadLine()??"0");
  return res;
}

//Выводим данные в консоль
void DataOutput(string data)
{
  Console.WriteLine(data);
}

//Метод возводит число "a" в степень "b"
long Exponent(int a, int b)
{
  long result = 1;
  for(int i = 0; i < b; i++)
  {
    result = result * a;
  }
  return result;
}

int numA = ReadNumber("Введите число: ");
int numB = ReadNumber("Введите степень: ");

DateTime d1 = DateTime.Now;
DataOutput("Вычисление через цикл: " + Exponent(numA, numB));
Console.WriteLine("тест скорости: " + (DateTime.Now - d1));


DateTime d2 = DateTime.Now;
Console.WriteLine("Вычисление через Math.Pow: " + Math.Pow(numA, numB));
Console.WriteLine("тест скорости: " + (DateTime.Now - d2));