// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон).

void Triangle ()
{
    Console.Write("Введите число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число 3: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number2 + number1)
    {
        Console.WriteLine($"Теугольник со сторонами: {number1}, {number2} и {number3} МОЖЕТ существовать");
    }
    else
    {
        Console.WriteLine($"Теугольник со сторонами: {number1}, {number2} и {number3} НЕ МОЖЕТ существовать");
    }
}
Triangle();