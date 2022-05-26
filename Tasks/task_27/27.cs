// Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
//int count = 0;
int sum = 0;
Console.WriteLine($"Сумма цифр в числе {number} =  ");
while (number > 0)
{
    sum =sum + number % 10;
    number = number / 10;
    //count ++;
}
Console.WriteLine(sum);

