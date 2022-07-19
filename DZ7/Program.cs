// // // Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// double[,] CreationRandomArray(int row, int column, double min, double max)
// {
//     double[,] array = new double[row, column];

//     for (int i = 0; i < row; i++)
//     {
//        for (int j = 0; j < column; j++)
//         { 
//             //array[i,j] = new Random().Next(min, max);
//             //Random().NextDouble();
//             array[i,j] = new Random().NextDouble()*(max-min)+min;
//             Console.Write($" {array[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// Console.Write("Задайте число строк: ");  
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте число столбцов: ");  
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве от: ");  
// double IntervalMin = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве до: ");  
// double IntervalMax = Convert.ToInt32(Console.ReadLine());

// CreationRandomArray(m, n, IntervalMin, IntervalMax);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreationRandomArray(int row, int column, int min, int max) // Метод формирования массива с помощью рандома
// {
//     int[,] array = new int[row, column];

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// void ElementSearch(int[,] array, int RowElem, int ColumnElem) // Метод поиск заданного элемента
// {
//     if (RowElem > array.GetLength(0) || ColumnElem > array.GetLength(1))
//         {
//           Console.WriteLine($"Элемента [{RowElem}; {ColumnElem}] в массиве нет");
//         }
//     else
//         {
//           Console.WriteLine($"Элемент массива [{RowElem}; {ColumnElem}] = {array[RowElem - 1, ColumnElem - 1]}");
//         }
// }

// int m = 10; // определение размера массива (10 х 10)
// int n = 10;
// int IntervalMin = -100; // определение интервала значений элементов массива (от -100 до 100)
// int IntervalMax = 100;

// Console.Write("Задайте номер строки ");  // Запрос у пользователя позиции элемента для поиска его значения в массиве 
// int RowElement = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте номер столбца ");  
// int ColumnElement = Convert.ToInt32(Console.ReadLine());

// int[,] AArray = CreationRandomArray(m, n, IntervalMin, IntervalMax);  // Заполнение массива с помощью рандома


// ElementSearch(AArray, RowElement, ColumnElement); // Вызов метода поиска заданного элемента 


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreationRandomArray(int row, int column, int min, int max) // Метод заполнения массива элементов рандом
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void AverageValueColumn(int[,] array) // Расчет среднего арифметического элементов столбцов
{
    Console.Write($"Среднее арифметическое элементов столбца: ");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];   // подсчет суммы элементов в столбце
        }

        average = sum / (array.GetLength(0));  // Определение среднего в столбце
        if (j == array.GetLength(1) - 1)
        {
            Console.Write($"{average:f1}.\n");
        }
        else
        {
            Console.Write($"{average:f1}; ");
        }
    }
}

Console.Write("Задайте число строк: ");  
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число столбцов: ");  
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве от: ");  
int IntervalMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве до: ");  
int IntervalMax = Convert.ToInt32(Console.ReadLine());

int[,] AArray = CreationRandomArray(m, n, IntervalMin, IntervalMax);

AverageValueColumn(AArray); // Вызов метода подсчета среднеарифметического по столбцам 

