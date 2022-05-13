
//Домашняя работа 2
/*
 Напишите программу,которая на вход принимает 
 два числа и выдает,какое число больше,а какое меньше.

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{ 
    Console.WriteLine("число{a} больше чем {b}");
}
else if(a == b)
{
    Console.WriteLine("Число{a} и {b} равны");
}
else
{
    Console.WriteLine("Число{b}  больше чем {a} ");
}

//Домашняя работа 4

Напишите программу,которая принимает на вход три
числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int c  = Convert.ToInt32(Console.ReadLine());

if(a >= b && a >= c)
{
    Console.WriteLine("Максимальное число {a}");
}
if (b >= a && b >=c)
{
    Console.WriteLine("Максимальное число {b}");
}
if (c >= a && c >= b)
{
    Console.WriteLine("Максимальное число {c}");
}


// Домашняя работа 6

Напишите программу,которая на вход принимает число и
выдает,является ли число четным
(делится ли оно на два без остатка).

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Домашняя работа 8

Напишите программу,которая на вход принимает число(N),а на выходе 
показывает все четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x <= number; x++)
{
    Console.Write(x);
    if(x % 2 == 0)
    {
        Console.WriteLine(" ,");
    }
}
*/