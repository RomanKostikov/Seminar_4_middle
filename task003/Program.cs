// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Print an integer: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumsProd(num1));

int NumsProd(int number)
{
    int Prod = 1;
    while (number > 1)
    {
        Prod = Prod * number;
        number--;
    }
    return Prod;
}