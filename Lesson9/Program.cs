// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int start, int end)
// {
// if (start==end)
// {
// return start.ToString();
// }

// return (start+" "+ PrintNumber(start-1,end));

// }

// Console.WriteLine(PrintNumber(n,1));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число");
// int m= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int CalculateSumm(int m, int n)
// {
//     int start = m;
//     int end = n;
//     if (m > n)
//     {
//         start = n;
//         end = m;
//     }
//     return (end + start) * (end - start + 1) / 2; 
// }

// Console.WriteLine(CalculateSumm(m,n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите число");
// int m= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int InputNumber(string input)
// {
// Console.Write(input);
// int output = Convert.ToInt32(Console.ReadLine());
// return output;
// }
// int Akkerman(int m, int n)
// {
// if (m == 0)
// {
// return n + 1;
// }
// else if (n == 0 && m > 0)
// {
// return Akkerman(m - 1, 1);
// }
// else
// {
// return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// }

// int akkermanFunction = Akkerman(m, n);
// Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");