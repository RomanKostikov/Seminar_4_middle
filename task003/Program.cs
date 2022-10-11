// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Print an integer: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumsProduct(num1));

int NumsProduct(int number)
{
    int Product = 1;
    while (number > 1)
    {
        Product = Product * number;
        number--;
    }
    return Product;
}