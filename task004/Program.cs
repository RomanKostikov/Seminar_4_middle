// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array01 = new int[8];
FillArray(array01);
WriteArray(array01);
void FillArray(int[] array)
{   
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = new Random().Next(0, 2);
        // Console.Write($"{array[i]}, ");
    }
    array[array.Length - 1] = new Random().Next(0, 2);
    // Console.Write(array[array.Length - 1]);
}
void WriteArray(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
}
