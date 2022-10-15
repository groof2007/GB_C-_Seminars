// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое значени: ");
int number1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе значени: ");
int number2 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите третье значени: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
{
    System.Console.WriteLine($"Максимальное число {number1}");
}
if (number2 > number1 && number2 > number3)
{
    System.Console.WriteLine($"Максимальное число {number2}");
}
else
{
    System.Console.WriteLine($"Максимальное число {number3}");
}