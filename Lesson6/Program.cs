﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Console.WriteLine("Введите количество чисел");
//int num=Convert.ToInt32(Console.ReadLine());
//int i=1;
//int count=0;

//while(i<num)
//{
//    Console.WriteLine("Введите число");
//    int num1=Convert.ToInt32(Console.ReadLine());
//    i++;
//    if (num1>0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("Количесто чисел больше нуля "+count);

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double k1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double b2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double k2=Convert.ToInt32(Console.ReadLine());

if (k1=k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
double x=(b1-b2/(k2-k1));
double y=k2*x+b2;
}

Console.WriteLine("Точка пересечения двух прямых:"+"  "+"("+x+";"+y+")");