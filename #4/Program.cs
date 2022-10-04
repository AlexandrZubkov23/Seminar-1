// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
string Num1 = Console.ReadLine() ?? " ";
int a = int.Parse(Num1);

Console.Write("Введите второе число: ");
string Num2 = Console.ReadLine() ?? " ";
int b = int.Parse(Num2);

Console.Write("Введите третье число: ");
string Num3 = Console.ReadLine() ?? " ";
int c = int.Parse(Num3);
int max = 0;

if (a > max)
{
    a = max;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write(max);