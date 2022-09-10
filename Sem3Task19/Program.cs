//====================================================================
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//====================================================================

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

string isItPalindrome(int number)
{
  string num = number.ToString();
  bool result = num[0] == num[4] && num[1] == num[3];
  return result ? "это палиндром" : "это не палиндром";
}

int palindrome = ReadNumber("Введите ваш палиндром: ");
DataOutput(isItPalindrome(palindrome));