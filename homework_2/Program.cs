// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Enter number: ");
int num1 = int.Parse(Console.ReadLine()!);
int len = NumDigits(PositiveNumber(num1));
SumNumbers(num1, len);
// Функция перевода в положительное число
int PositiveNumber(int number)
{
    if (number < 0)
    {
        number *= -1;
    }
    return number;
}
// Функция подсчета цифр в числе
int NumDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}
