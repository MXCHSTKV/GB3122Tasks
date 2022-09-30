//=========================================================================================
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
//=========================================================================================

// Чтение данных в консоли
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Печать трехмерного массива
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                 Console.Write($" {array3D[i, j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

// Заполнение трехмерного массива
int[,,] Fill3DArray(int i, int j, int k, int min, int max)
{
    int element;
    int[,,] array3D = new int [i, j, k];
    for ( i = 0; i < array3D.GetLength(0); i++)
    {
        for ( j = 0; j < array3D.GetLength(1); j++)
        {
            for ( k = 0; k < array3D.GetLength(2); k++)
            {
               do
               {
                element = new Random().Next(min, max+1);
               }
               while (FindElement(array3D, element));
                array3D[i, j, k] = element;
            }
        }
    }
    return array3D;
}

bool FindElement(int[,,]array3D, int element)
{
 for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == element) return true;
                if (array3D[i, j, k] == 0) return false;
            }
        }
    }
    return false;
}


int i = ReadData("Введите параметр Z: ");
int j = ReadData("Введите число строк Y: ");
int k = ReadData("Введите число столбцов Х: ");

int[,,] array3D = new int[i,j,k];
int min = 10;
int max = 99;
array3D = Fill3DArray(i, j, k, min, max);
Console.WriteLine();
Print3DArray(array3D);