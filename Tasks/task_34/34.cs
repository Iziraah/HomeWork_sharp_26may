// Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

int[] nums = new int[12];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(100, 1000);
    Console.Write(nums[i] + " ");
}
int numPositive = 0;
for (int i=0; i<nums.Length ; i++)
{
    if (nums[i]%2==0) numPositive += 1;
}
Console.WriteLine();
Console.WriteLine(numPositive);