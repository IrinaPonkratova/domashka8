// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

int InputInt(string msg)
{
    System.Console.WriteLine(msg + ": ");
    return Convert.ToInt32(Console.ReadLine());
}
int [,] CreateArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100);
        }
    }
    return array;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    System.Console.WriteLine();
}
int [,] arr = CreateArray();
PrintArray(arr);
int m = InputInt("введите  номер строки");
int n = InputInt("введите  номер столбца");
if (m < 1 || n < 1 ||m > arr.GetLength(0) || n > arr.GetLength(1) )
{
    System.Console.WriteLine("такого элемента в массиве нет");
}
else 
{
    System.Console.WriteLine($"значение элемента рано {arr[m-1, n - 1]}");
}