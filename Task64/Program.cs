﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNum(int num)
{ 
    Console.Write(num + " ");
    if(num<=0)Console.WriteLine("Input positive number");
    else if(num>1) ShowNum(num-1);
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Natural numbers in the range from N to 1 are: ");
ShowNum(number);