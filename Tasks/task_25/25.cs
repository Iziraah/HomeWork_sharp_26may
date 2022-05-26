// Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.

Console.WriteLine("Введите натуральное число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = int.Parse(Console.ReadLine());
int sqr = numberA;
for (int i=2; i<=numberB; i++)
{
    sqr = sqr * numberA;
    
}
Console.WriteLine($"{numberA} в степени {numberB} = {sqr}");