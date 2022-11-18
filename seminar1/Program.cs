/* 1  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Input number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num1}");
}
else 
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num2}");
}
*/




/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Console.WriteLine("Input a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

 Console.WriteLine($"{a},{b},{c} -> {max}");
 */



 
 /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


 Console.WriteLine("Input number");
 int num = Convert.ToInt32(Console.ReadLine());

int sum = num % 2;

if (sum == 0) 
{
    Console.WriteLine($"{num} -> Да");
}
else 
{
    Console.WriteLine($"{num} -> Нет");
}
*/




/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());

int countN = 2;

Console.Write($"{n}-> ");
while(countN <= n)
{
    Console.Write($"{countN}, ");
    countN +=2;
}
*/