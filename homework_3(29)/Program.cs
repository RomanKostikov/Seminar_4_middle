// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

Console.Clear();
int[] array01 = new int[8];
FillArray(array01);
WriteArray(array01);
// Функция задает массив
void FillArray(int[] array)
{   
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = new Random().Next();
    }
    array[array.Length - 1] = new Random().Next();
}
// Функция вывода массива на экран
void WriteArray(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
}