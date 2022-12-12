// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
int N = 2;
if (number >= 2)
{
    for (;N <= number; N += 2)
       {
         Console.WriteLine(N);
        }
}
else
{
 Console.WriteLine("Введи другое число");   
}
  
//int result = number % 2;
//if (result == 0)
//{
//    Console.WriteLine("Это четное число");
//}
// else
//{
//    Console.WriteLine("Это нечетное число");
//}
