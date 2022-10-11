// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
// PositiveNumber(num1);
Console.WriteLine(NumDigits(num1));

// // int PositiveNumber(int number)
// {
//     if (number < 0)
//     {
//         number *= -1;
//     }
// }
int NumDigits(int number)
{
    int count = 0;
    while (number > 1)
    {
        number /= 10;
        count++;
    }
    return count;
}