//Найходим введеное число и выдаем его позицию.

Console.WriteLine("Введите размер двумерного массива: ");
Console.WriteLine("Введите i: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите j: ");
int y = int.Parse(Console.ReadLine());
int[,] matrix = new int[x, y];
Console.WriteLine("Введите искомое число: ");
int z = int.Parse(Console.ReadLine());

void FillArray(int[,] one)
{
    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < one.GetLength(1); j++)
        {
            one[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] two)
{
    for (int i = 0; i < two.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            Console.Write(two[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] three, int find)
{
    for (int i = 0; i < three.GetLength(0); i++)
    {
        for (int j = 0; j < three.GetLength(1); j++)
        {
            if(three[i, j] == find)
            {
                Console.WriteLine("Найденный элемент " + find + " находиться в [" + i + ", " + j + "]");
                return;
            }
        }
    }
    Console.WriteLine("В данном массиве нет даного числа. ");
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindNumber(matrix, z);

