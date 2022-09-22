// ----------------------------------------------------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// ----------------------------------------------------------------------------


// Получение данных от пользователя и преобразование в число
double ReadData(string text)
{
  Console.Write(text);
  double number = double.Parse(Console.ReadLine()??"0");
  return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Поиск точки пересечения двух прямых
double[] SearchIntersection(double k1, double b1, double k2, double b2)
{
    double[] outArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}
double b1 = ReadData("Введите b1: ");
double k1 = ReadData("Введите k1: ");
double b2 = ReadData("Введите b2: ");
double k2 = ReadData("Введите k2: ");
double[] intersection = SearchIntersection(k1, b1, k2, b2);
PrintResult($"Точка пересечения прямых: ({Math.Round(intersection[0],2)};{Math.Round(intersection[1], 2)})");
