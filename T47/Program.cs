//Задача 47. Задайте двумерный массив размером m×n, 
// случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
double[,] GreatMatrix(int m, int n, int min, int max){
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double number = rnd.NextDouble() * (max - min) + min;
            number = Math.Round(number,1);
            matrix[i,j] = number;

        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" {0,5} |", matrix[i,j]);
        }
        Console.WriteLine();
    }
}
Console.Write("Задайте число строк и столбцов массива. Число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте нижнюю границу массива  min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте верхнюю границу массива  max = ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] newmatrix = GreatMatrix(m,n,min,max);
PrintMatrix(newmatrix);