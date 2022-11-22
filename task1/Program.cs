// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a > 5; b < 7 -> max = 7; a > 2 b < 10 -> max = 10; a > -9 b < -3 -> max = -


Console.WriteLine("Ether the number:");
int num1 = int.Parse(Console.WriteLine());
Console.WriteLine("Ether the number:");
int num2 = int.Parse(Console.WriteLine());


if(num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}