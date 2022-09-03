//Написать программу, которая обменивает элементы первой строки и последней строки.

int[,] FillArray(int[,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            one[i, j] = new Random().Next(1, 20);
        }
    }
    return one;
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

void PermutationStrings(int[,] three, int[] oneString, int[] twoString, int a, int z)
{
    for (int k = 0; k < a; k++)
    {
        oneString[k] = three[0, k]; 
    }
    
    for (int k = 0; k < a; k++)
    {
        twoString[k] = three[z - 1, k]; 
    }
    
    for (int k = 0; k < a; k++)
    {
        three[0, k] = twoString[k];
    }
    
    for (int k = 0; k < a; k++)
    {
        three[z - 1, k] = oneString[k];
    }
}

Console.WriteLine("Введите размер двумерного масива: ");
Console.WriteLine("Введите i: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите j: ");
int y = int.Parse(Console.ReadLine());
int[,] array = new int[x, y];
int[] arrayStringOne = new int[x];
int[] arrayStringTwo = new int[x];

FillArray(array);
PrintArray(array);
Console.WriteLine();

PermutationStrings(array, arrayStringOne, arrayStringTwo, y, x);
PrintArray(array);