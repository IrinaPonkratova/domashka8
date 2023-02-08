// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateArray()
{
    Random rnd = new Random();
    int[,] array = new int[3,4];
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
double [] Average(int [,] array)
{
    double [] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            average[j] += average[i,j];
        } 
        average[i] /= average.GetLength(0);
    }
    return average;
}
/*void PrintAverage(double [] array)
{
    System.Console.WriteLine("среднее арифметическое столбцов: ");
    for (int i = 0; i < array.Length; i++)
    {
        Average(int)
    }
}
*/
int [,] arr = CreateArray();
PrintArray(arr);
double aver = Average(arr);