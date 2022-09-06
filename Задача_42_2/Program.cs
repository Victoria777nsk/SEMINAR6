Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool[] array = Num2(num);

Console.WriteLine(String.Join("", array));
for (int i = 0; i < array.Length; i++)
{
    Console.Write(Convert.ToInt32(array[i]));
}

bool[] Num2 (int num) // bool равносильно 1 БИТу
{
    int result = 0;
    bool[] arr = new bool[32]; // размерность массива = 32 бита, т.к. введеное число int занимает 32 бита.
    int i;
    for (i = 0; num > 0; i++)
    {
        result = num % 2;
        num = num / 2;
        arr[arr.Length -1 -i] = Convert.ToBoolean(result);
    }
    return arr;
}