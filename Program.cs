// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Enter value = number of Rows : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value = number of Columns : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of the row in which the cell is located : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of the column in which the cell is located : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value you want to find : ");
int SRCValue = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[x, y];
int count = 0;

void SRCPosition(int[,] Matrix, int m, int n)
{
    int Result = 0;
    bool Flag;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Matrix[i, j] = new Random().Next(0, 10);
            if (i == m && j == n) { Result = Matrix[i, j]; Flag = true; }
            if (Matrix[i, j] == SRCValue)
            {
                count++;
            }
            Console.Write($"{Matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    if (Flag = true) { Console.WriteLine(Result); }
    else { Console.WriteLine("This cell does not exist in the array"); }
}

void SRCValuePosition(int[,] Matrix)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (Matrix[i, j] == SRCValue)
            { Console.WriteLine($"{Matrix[i, j]} --> ({i}, {j})"); }
            else if (i == x -1 && j == y - 1 && Matrix[i, j] != SRCValue)
            {
                Console.WriteLine("This value is not in the array");
            }
        }
    }
}
SRCPosition(Matrix, m, n);
SRCValuePosition(Matrix);