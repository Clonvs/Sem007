//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// using System;
// namespace CSharp_Shell
// { public static class Program
// { public static void Main()
// { Int32 k, l, m, n;
// Console.Write("m n: ");
// var s = Console.ReadLine().Split(" ");
// m = Convert.ToInt32(s[0]);
// n = Convert.ToInt32(s[1]);
// Random rnd = new Random();
// double [,] A = new double [m,n];
// for (k = 0; k < m; k++)
// { for (l = 0; l < n; l++)
// { A[k,l]=20.0*rnd.Next()/2147483648-10.0;
// Console.Write(String.Format("{0,5:f1}",
// A[k,l])); } Console.WriteLine(); } } } }

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] GetArray (int row, int column, int minVallue, int maxVallue)
// {
//     int [,] resualt = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             resualt[i, j] = new Random().Next(minVallue,maxVallue + 1);
//         }
//     }
//     return resualt;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строк элемента: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер Столбца элемента: ");
// int d = Convert.ToInt32(Console.ReadLine());

// int [,] array = GetArray(rows, columns, 0, 100);
// PrintArray(array);


// if (b < rows && d < columns){ 
//     int element = array[b,d];
//     Console.WriteLine($" Запрашиваемый элемент: -> {element}");
// }  
//  else{
//     Console.Write("Числа нет");

// }
// {
    
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// int [,] GetArray (int row, int column, int minVallue, int maxVallue)
// {
//     int [,] resualt = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             resualt[i, j] = new Random().Next(minVallue,maxVallue + 1);
//         }
//     }
//     return resualt;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write("Среднее арифметическое каждого столбца:");

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          sum = sum + array [i,j];
//     }
//     Console.Write($"{sum/rows:f1} ");
// }