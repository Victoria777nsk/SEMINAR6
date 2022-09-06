// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
}
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int[] copyArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    copyArray[i] = array[i];
}
Console.WriteLine($"Копия: [{String.Join(", ", copyArray)}]");
