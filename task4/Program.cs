//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите размер двумерного массива: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());
int[,] matrix = new int[x, y];
int[] miniMatrix = new int[y];

int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] array = new int[length, width];
    Random random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = random.Next(minimum,maximum);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
}

int[,] SortingMaxToMin(int[,] matrixOne, int[] matrixTwo)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrixTwo[j] = matrixOne[i, j];
        }
        
        Array.Sort(matrixTwo);
        Array.Reverse(matrixTwo);

        for (int j = 0; j < y; j++)
        {
            matrixOne[i, j] = matrixTwo[j];
        }
    }
    return matrix;
}


CreateMatrix(x, y, min, max);
PrintMatrix(matrix);
Console.WriteLine();
SortingMaxToMin(matrix, miniMatrix);
PrintMatrix(matrix);

 