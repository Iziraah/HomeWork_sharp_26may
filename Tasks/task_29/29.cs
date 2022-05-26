// Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
//Размер массива определяется пользователем.

Console.WriteLine("Программа по генерации массива");
int [] Gen_array()
{
    Console.WriteLine("Введите число элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    int [] arr = new int [n];
    Random rand = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
        arr [i] = rand.Next(1,100);
    }
    return arr;
}
int [] newarr = Gen_array();
var str = string.Join(" ", newarr);
Console.WriteLine(str);