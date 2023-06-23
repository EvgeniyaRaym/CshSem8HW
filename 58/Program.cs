// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();

Write("Давайте перемножим массивы. Введите количество строк массива номер 1: ");
int rowsN1 = int.Parse(ReadLine());
Write("Введите количество столбцов массива номер 1: ");
int columnsN1 = int.Parse(ReadLine());
Write("Создадим вторую матрицу. Введите количество строк массива номер 2: ");
int rowsN2 = int.Parse(ReadLine());
Write("Введите количество столбцов массива номер 2: ");
int columnsN2 = int.Parse(ReadLine());
while (columnsN1 != rowsN2)
{
    WriteLine("Эти массивы не подходят для умножения. Введите новые значения для матрицы: ");
    Write("Давайте перемножим массивы. Введите количество строк массива номер 1: ");
    rowsN1 = int.Parse(ReadLine());
    Write("Введите количество столбцов массива номер 1: ");
    columnsN1 = int.Parse(ReadLine());
    Write("Создадим вторую матрицу. Введите количество строк массива номер 2: ");
    rowsN2 = int.Parse(ReadLine());
    Write("Введите количество столбцов массива номер 2: ");
    columnsN2 = int.Parse(ReadLine());
}

int[,] N1 = GetArray(rowsN1, columnsN1, 0, 10);
int[,] N2 = GetArray(rowsN2, columnsN2, 0, 10);
WriteLine("Первый массив: ");
PrintArray(N1);
WriteLine("Второй массив: ");
PrintArray(N2);
WriteLine("Произведение массивов: ");
PrintArray(MultiArray(N1,N2));

int[,] MultiArray(int[,] N1, int[,] N2)
{
    int[,] resarray = new int[N1.GetLength(0), N2.GetLength(1)];
    for (int i = 0; i < N1.GetLength(0); i++)
    {
        for (int j = 0; j < N2.GetLength(1); j++)
        {
            for (int k = 0; k < N1.GetLength(1); k++)
            {
                resarray[i, j] += N1[i, k] * N2[k, j];
            }
        }
    }
    return resarray;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}