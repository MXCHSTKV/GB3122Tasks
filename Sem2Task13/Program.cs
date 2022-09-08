//=======================================================================
// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//=======================================================================

Console.Write("Введите число: ");
string inputNumber = Console.ReadLine()??"";
int nLength = inputNumber.Length;
int number = int.Parse(inputNumber);

int inumber = nLength > 3 ? (int)(number / Math.Pow(10, (nLength - 3))) : number;
Console.Write("Третья цифра: ");
Console.WriteLine(inumber < 100 ? "третьей цифры нет" : inumber % 10);