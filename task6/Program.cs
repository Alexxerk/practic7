//В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int[]array = new int[x];
int{,} matrix = new int[x, y];
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());
int summa = 0;

if(x == y)
{
    Console.WriteLine("Вы ввели не корректный маштаб массива(размер строк и столбов должен отличаться)! ");
}

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

int[] SumEveryColumns (int[,] one, int[] two)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            summa = summa + one[i, j];
        }
        two[i] = summa;
    }
    return two;
}

void SearchMinSum (int[] one)
{
    int min = one[0];
    for (int i = 1; i < x; i++)
    {
        if(min1 < one[i])
        {
            i++;
        }
        else
        {
            min1 = one[i];   
        }
    }
    for (int i = 0; i < x; i++)
    {
        if(min = one[i])
        {
            Console.WriteLine("Строка с минимальной суммой == " + min + " находится на позиции индекса == " + i);
            break;
        } 
    }
}

CreateMatrix(x, y, min, max);
PrintMatrix(matrix);
Console.WriteLine();
SumEveryColumns(matrix, array);
SearchMinSum(array);






