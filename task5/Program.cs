//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if(x != y)
{
    Console.WriteLine("Вы ввели не коректные параметры массива! ");
    return;
}

int[,] matrix = new int[x, y];
int[,] arrayTwo = new int[y, x];
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());



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

int[,] ReplacingRowsWithColumns(int[,] matr, int[,] matr2)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            matr2[j, i] = matr[i, j];
        }
    }
    return matr2;
}
    
CreateMatrix(x, y, min, max);
PrintMatrix(matrix);
Console.WriteLine();
ReplacingRowsWithColumns(matrix, arrayTwo);
PrintMatrix(arrayTwo); 