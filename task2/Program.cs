//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.WriteLine("Введите размер двумерного масива: ");
Console.WriteLine("Введите i: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите j: ");
int y = int.Parse(Console.ReadLine());
int arithmeticMean = 0;

int[,] array = new int[x, y];

int[] miniArray = new int[y];

void FillArray(int[,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            one[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] two)
{
    for (int i = 0; i < two.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            Console.Write(two[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}

void FindArithmeticMean(int[,] three, int arithmetic, int [] mini)
{
    for (int j = 0; j < three.GetLength(1); j++)
    {
        for (int i = 0; i < three.GetLength(0); i++)
        {
            arithmetic = arithmetic + three[i, j];
        }
        float arithmeticFloat = (float)arithmetic;
        float y2 = (float)y;
        arithmeticFloat = arithmeticFloat / y2;
        Console.Write("{0,6:F2} ", arithmeticFloat);
        Console.Write(" ");
        arithmetic = 0;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindArithmeticMean(array, arithmeticMean, miniArray);

