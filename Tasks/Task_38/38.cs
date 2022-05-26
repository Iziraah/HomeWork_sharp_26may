// Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

int[] nums = new int[12];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 100);
    Console.Write(nums[i] + " ");
}

int GetMax = nums[0];
int GetMin = nums[0];
for (int i=0; i<nums.Length ; i++)
{
    if (nums[i] < GetMin)
    {
        GetMin = nums[i];
    }
    else
    if (nums[i] > GetMax)
    {
        GetMax = nums[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Максимальное число - {GetMax}");
Console.WriteLine($"Минимальное число - {GetMin}");
int diff = GetMax - GetMin;
Console.WriteLine($"Разница между максимальным и минимальным числом - {diff}");
