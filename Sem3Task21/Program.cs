//===============================================================
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
//===============================================================

int ReadNumber(string text)
{
  Console.Write(text);
  int res = int.Parse(Console.ReadLine()??"0");
  return res;
}

void DataOutput(double data)
{
  Console.WriteLine(Math.Round(data, 2));
}

double LengthOfLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
  return result;
}

int x1 = ReadNumber("Введите x1: ");
int y1 = ReadNumber("Введите y1: ");
int z1 = ReadNumber("Введите z1: ");
int x2 = ReadNumber("Введите x2: ");
int y2 = ReadNumber("Введите y2: ");
int z2 = ReadNumber("Введите z2: ");

DataOutput(LengthOfLine(x1, y1, z1, x2, y2, z2));