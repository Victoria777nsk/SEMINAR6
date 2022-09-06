// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int value = number;

void Binary()
{
    int count = 0; // кол-во прохождений цикла while
    int temp = number;

    while (number != 0) // пока НЕ равно нулю
    {
        number /= 2;
        count++;
    }
    int[] BinArray = new int[count];

    count--;
    while (temp != 0)
    {
        BinArray[count] = temp % 2;
        temp /= 2;
        count--;
    }
    Console.Write($"Число {value} в двоичной системе: " + String.Join(" ", BinArray));
}
Binary();

Console.WriteLine();

void Binary2()
{
    string binary = Convert.ToString(value, 2);
    Console.WriteLine($"Число {value} в двоичной системе: {binary}");
}
Binary2();