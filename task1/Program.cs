//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое значени: ");
int number1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе значени: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    System.Console.WriteLine($"Большее число {number1}, меньшее число {number2}");
}
else
{
    System.Console.WriteLine($"Большее число {number2}, меньшее число {number1}");
}
