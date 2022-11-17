//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] Great2D(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PtintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,4} |", matr[i, j]);
        }
        Console.WriteLine();
    }
}
void AveragElementColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result = result + matrix[i, j];
        }
        result = result / matrix.GetLength(0);
        result = Math.Round(result, 1);
        Console.Write($"{result};   ");

    }
}
Console.Write("Задайте размеры двумерного массива. Число строк = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов = ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижняя граница массива =  ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница массива =  ");
int max= Convert.ToInt32(Console.ReadLine());
int[,] newmatrix = Great2D(row,column,min,max);
PtintMatrix(newmatrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
AveragElementColumns(newmatrix);
