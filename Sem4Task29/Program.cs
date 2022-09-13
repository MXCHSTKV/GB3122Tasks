//=================================================================================
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//=================================================================================

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

int length = ReadNumber("Какой длины будет массив?: ");
int fromNum = ReadNumber("Интервал значений, от: ");
int toNum = ReadNumber("до: ");

// Функция создает массив заданной длины, с рандомными элементами в заданном интервале.
string RandowArr(int lng, int from, int to)
{
  int[] array = new int[lng];
  Random rnd = new Random();

  for(int i = 0; i < length; i++)
  {
    array[i] = rnd.Next(from, to+1);
  }

  return string.Join(", ", array);
}


DataOutput("[" + RandowArr(length, fromNum, toNum) +"]");