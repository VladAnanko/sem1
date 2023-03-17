﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
int LeftBorder =cons ("введите левую границу: ");
int RightBordr =cons ("введите правую границу: ");

int [,] matrix = randomMatrix (rows, colomns, LeftBorder, RightBordr);
PrintMatrix(matrix);
average(matrix);
}

int [,] randomMatrix (int row, int colomns, int LeftBorder, int RightBordr)
{
int [,] matrix = new int [row,colomns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Random.Shared.Next(LeftBorder,RightBordr +1);
    }
}
return matrix;
}

void PrintMatrix (int [,] matrix)
{
Console.WriteLine("полученый массив:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+"    ");
    }
    Console.WriteLine();
}
}

void average (int [,] matrix)
{
int average = 0;
int count = 0;
Console.WriteLine("!!AVERAGE:!!");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average += matrix [i,j];
        count++;
    }
    Console.Write($"{Math.Round((double)average/count, 1)}  ");
}

}

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
main();