// Задача 2: Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
string Firstnum = Console.ReadLine() ??" ";
int a = int.Parse(Firstnum);

Console.Write("Введите второе число: ");
string Firstnum1 = Console.ReadLine() ??" ";
int b = int.Parse(Firstnum1);

if (a > b)
{
    Console.Write(+ a + " большее " + b + " меньшее");
    
}
else 
{
    Console.Write(+ b + " большее " + a + " меньшее");
}