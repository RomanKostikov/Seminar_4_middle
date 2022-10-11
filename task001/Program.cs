// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр={GetSumNums(num)}"); //теперь метод можно использовать для других переменных
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр={GetSumNums(num1)}");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр={GetSumNums(num2)}");

int GetSumNums(int number)
{
    int sum =0;
    while(number>0)
    {
        sum+=number;
        number--;
    }
    return sum;
}