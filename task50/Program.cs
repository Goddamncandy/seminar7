// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 20);
        }
}
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите координаты элемента");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a >= m || b >= n) Console.WriteLine("Такого элемента нет");
else 
{
    object c = matrix.GetValue(a, b);
    Console.WriteLine(c);
}