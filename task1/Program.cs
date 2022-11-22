// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a > 5; b < 7 -> max = 7; a > 2 b < 10 -> max = 10; a > -9 b < -3 -> max = -

Console.WriteLine("Ether the number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ether the number:");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1} > {num2}");
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"{num1} < {num2}");
    Console.WriteLine($"max = {num2}");
}
