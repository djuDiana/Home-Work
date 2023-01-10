//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

//Console.WriteLine("Введите число А");
//int A=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число В");
//int B=Convert.ToInt32(Console.ReadLine());

//double St()
//{
  //  double p=Math.Pow (A,B);
    //return p;
//}
//Console.WtiteLine($"Результат возведения в степень {St()}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

//Console.WriteLine("Введите число");
//int num=Convert.ToInt32(Console.ReadLine());
//int sum=0;

//int Function()
//{
//    while (num>0)
//    {
//        int temp=num%10;
//    sum=sum+temp;
//     num=num/10;
//   }
//    return sum;
//}
//Console.WriteLine("сумма всех цифр числа равна:" + Function());

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int [] print()
{
    int [] array=new int[8];
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива /n");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine(string.Join(",", print()));