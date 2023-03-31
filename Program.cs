// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число А->");
        string valueA; // Объявление переменной типа строка
        valueA = Console.ReadLine(); // Считываем с консоли строку
        int numberA = Convert.ToInt32(valueA); // переводим введеное значение в числовой режим
        int numberX = 1;

        while (numberX <= numberA)
        {
            int ostatok = numberX % 2;
            if (ostatok == 0)
            {
                Console.WriteLine (numberX);
            }
            numberX = numberX + 1;
        }
    }
}

