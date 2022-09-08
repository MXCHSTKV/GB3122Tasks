﻿//==============================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
//==============================================================================

Console.Write("Введите номер дня недели от 1 до 7: ");
string inputNumber = Console.ReadLine()??"";
int number = int.Parse(inputNumber);

Console.WriteLine("Определяем, является ли этот день выходным");
Console.Write((number < 1 || number > 7) ? "Такого дня нет" : (number < 6 ? "нет" : "да"));