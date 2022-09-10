//======================================================
// Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу кубов чисел от 1 до N.
//======================================================

int ReadNumber(string text)
{
  Console.Write(text);
  int res = int.Parse(Console.ReadLine()??"0");
  return res;
}

void DataOutput(string data)
{
  Console.WriteLine(data);
}


string StringOfNumbers(int num, int exp)
{
  string result = "1";
  for(int i = 2; i <= num; i++)
  {
    result = result + "\t" + Math.Pow(i, exp).ToString();
  }
  return result;
}

int N = ReadNumber("Введите число N: ");

string line1 = StringOfNumbers(N, 1);
string line2 = StringOfNumbers(N, 3);

DataOutput(line1);
DataOutput(line2);
