//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
double [,] CreateArray()
{
    
    double[,] array = new double[3,4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.Next(-100, 101)*0.1, 1);
        }
    }
    return array;
}
void PrintArray(double [,] array)
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
double [,] resultArray = CreateArray();
PrintArray(resultArray);