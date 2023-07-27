/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
*/
/*double[,] CreateDoubleArray (int rows, int columns)
{
   double[,] array = new double[rows, columns];
    Random random = new Random();
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.NextDouble() * 10 ;
            array[i,j] = Math.Round(array[i,j], 2);
        }
   }        
    return array;
}         
void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
Console.Write ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
double[,] myArray = CreateDoubleArray(rows, columns);
PrintArray(myArray);
*/
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
*/
/*
int[,]  CreateMyArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;
}     
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
void PrintElementIndex(int[,] array)
{
    Console.Write("Enter the index of the row number: ");
    int indexrows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the index of the column number: ");
    int indexcolumns = Convert.ToInt32(Console.ReadLine());
    if ( indexrows > array.GetLength(0) ||  indexcolumns > array.GetLength(1))
    {
        Console.WriteLine("Error");
        return;
    }
    Console.WriteLine(array[indexrows, indexcolumns]);
}
Console.Write ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
int[,] myArray = CreateMyArray  (rows, columns, minValue, maxValue);
PrintArray(myArray);
PrintElementIndex(myArray);
*/
/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
*/
int[,]  CreateNewArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;
}     
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
double[] ArithmeticMeanColumns(int[,] array, int columns, int rows)
{
        double[] columnMeans = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double columnMean = sum / rows;
        columnMeans[j] = columnMean;
        Console.WriteLine("Column sum " + (j + 1) + " -> " + sum);
        Console.WriteLine("Arithmetic mean of the column " + (j + 1) + " -> " + columnMean);
    }
    return columnMeans;
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
int[,] myArray = CreateNewArray  (rows, columns, minValue, maxValue);
PrintArray(myArray);
ArithmeticMeanColumns(myArray, columns, rows);
