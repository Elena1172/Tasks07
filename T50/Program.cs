//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
void ValueElementMatrix(int m, int n, int[,] matrix)
{
    if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
    {
        Console.WriteLine("Элемента с заданными позициями  в двумерном массиве нет.");
    }
    else Console.Write($"Значение элемента с заданными позициями = {matrix[m-1, n-1]}");

}
int[,] GreatMatrix(int rows, int colums){
    int[,]matrix = new int[rows,colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i,j] = rnd.Next(1,100); 
        }
    }
    return matrix;
}
int[,] newMatrix = GreatMatrix(5,7);
Console.Write("Позиции элемента в массиве: номер строки ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
ValueElementMatrix(row,column,newMatrix);
