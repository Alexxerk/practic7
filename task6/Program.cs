//В прямоугольной матрице найти строку с наименьшей суммой элементов.

/* Квадратом называется прямоугольник, у которого все стороны равны.
Свойства квадрата. Квадрату присущи все свойства параллелограмма.
Квадрат можно считать ромбом с прямыми углами или прямоугольником с равными сторонами, 
поэтому квадрат обладает всеми свойствами ромба и прямоугольника. */

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

//if(x == y)
//{
//    Console.WriteLine("Вы ввели не коректные параметры массива! ");
//   return;
//}

int[]array = new int[x];
int[,] matrix = new int[x, y];
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());
int summa = 0;
int newMin = 0;



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
        summa = 0;
        for (int j = 0; j < one.GetLength(1); j++)
        {
            summa = summa + one[i, j];
        }
        two[i] = summa;
        Console.WriteLine(two[i]);
    }
    return two;
}

void SearchMinSum (int[] one, int min1)
{
    min1 = one[0];
    for (int k = 0; k < x; k++)
    {
        if (min1 > one[k])
        {
            min1 = one[k]; 
            
        }
    }  

    for (int i = 0; i < x; i++)
    {
        if(min1 == one[i])
        {
            Console.WriteLine("Строка с минимальной суммой == " + min1 + " находится на позиции индекса == " + i);
            break;
        } 
    }
}

CreateMatrix(x, y, min, max);
PrintMatrix(matrix);
Console.WriteLine();
SumEveryColumns(matrix, array);
SearchMinSum(array, newMin);






