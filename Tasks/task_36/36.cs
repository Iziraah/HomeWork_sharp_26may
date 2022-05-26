// Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

int[] nums = new int[12];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 10);
    Console.Write(nums[i] + " ");
}
int sumPositive = 0;
for (int i=1; i<nums.Length ; i=i+2)
{
    sumPositive = sumPositive + nums[i];
}
Console.WriteLine();
Console.WriteLine(sumPositive);