//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введи число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <6)
  Console.WriteLine("Это рабочий день");
else
  Console.WriteLine("Это выходной день");