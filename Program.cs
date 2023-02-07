// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Enter value = nums Rows : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value = nums Columns : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter # Rows : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter # Columns : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[x, y];
int Result = 0;

void SRCPosition(int[,] Matrix, int m, int n)
{
    int Z = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Matrix[i, j] = new Random().Next(0, 10);
            if (i == m && j == n) { Result = Matrix[i, j]; Z++; }
            Console.Write($"{Matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    if (Z > 0)
    {
        Console.WriteLine(Result);
    }
    else
    {
        Console.WriteLine("Данной ячейки не существует");
    }
}
SRCPosition(Matrix, m, n);