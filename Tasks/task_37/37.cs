// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите число элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 10);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
for (int i=0; i < nums.Length/2; i++)
{
    nums[i] = nums[i] * nums[nums.Length - 1 - i];
    Console.Write(nums[i] + " ");
}
if (nums.Length%2 != 0) 
{
     Console.Write(nums[nums.Length/2]);
}