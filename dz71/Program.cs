
// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());

// if (n == m)   // проверка массива на прямоугольность
// {
//     Console.WriteLine("Массив не прямоугольный. Задайте количество строк не равное количеству столбцов");
//     return;
// }
// Console.Write("Задайте диапазон элементов в массиве от: ");
// int IntervalMin = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве до: ");
// int IntervalMax = Convert.ToInt32(Console.ReadLine());

// int[,] AArray = CreationRandomArray(n, m, IntervalMin, IntervalMax); // заполнение массива случайными числами

// int[,] CreationRandomArray(int row, int column, int min, int max) // Метод заполнения массива случайными числами
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

// int[] SummArray(int[,] array) // Расчет суммы элементов в строках и запись сумм в одномерный массив
// {
//     int[] aarray = new int[array.GetLength(0)];
//     Console.Write($" Сумма по строкам: ");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];   // подсчет суммы элементов в строке
//         }
//         aarray[i] = sum;
//         Console.Write($" {aarray[i]} ");
//     }
//     return aarray;
// }

// MimRow(SummArray(AArray)); // Вызов метода поиска строки с наименьшей суммой

// void MimRow(int[] array) // Метод поиска строки с наименьшей суммой
// {
//     int min = array[0];
//     int indexrowmin = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//             indexrowmin = i;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {indexrowmin + 1} строка. минимальная сумма = {min}");
// }

// // Задача 54: Задайте двумерный массив. 
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreatureRandomArray(int size, int column, int min, int max) // Метод заполнения массива случайными числами
// {
//     int[,] array = new int[size, column];

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i,j] = new Random().Next(min, max);
//             Console.Write(array[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// void SortingArray(int[,] array)  // Метод сортировки по убыванию элементов строки
// {
//     Console.WriteLine("Отсортированный массив (строки по убыванию) ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int a = j + 1; a < array.GetLength(1); a++)
//             {
//                 if (array[i, j] < array[i, a])
//                 {
//                     int max = array[i, j];
//                     array[i, j] = array[i, a];
//                     array[i, a] = max;
//                 }
//             }
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");  
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");  
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве от: ");  
// int mina = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве до: ");  
// int maxa = Convert.ToInt32(Console.ReadLine());

// int[,] AArray = CreatureRandomArray(n, m, mina, maxa); // Формирование массива

// Console.WriteLine();

// SortingArray(AArray); // Вызов метода сортировки массива


// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreatureRandomArray(int size, int column, int min, int max) // Метод формирования матрицы
// {
//     int[,] array = new int[size, column];

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// Console.Write("Задайте число строк массива 1: ");  
// int m1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте число столбцов массива 1: ");  
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте число строк массива 2: ");  
// int m2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте число столбцов массива 2: ");  
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1!=m2)                                     // Проверка можно ли перемножить матрицы
// {
//     Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
//     return;
// }
// Console.Write("Задайте диапазон элементов в массиве от: ");  
// int IntervalMin = Convert.ToInt32(Console.ReadLine());

// Console.Write("Задайте диапазон элементов в массиве до: ");  
// int IntervalMax = Convert.ToInt32(Console.ReadLine());

// int[,] AArray = CreatureRandomArray(m1, n1, IntervalMin, IntervalMax); // Формирование матрицы 1
// Console.WriteLine();
// int[,] ВArray = CreatureRandomArray(m2, n2, IntervalMin, IntervalMax); // Формирование матрицы 2
// Console.WriteLine();

// void MultiplicationArray(int[,] AArray, int[,] ВArray)                 // Метод перемножения 2 матриц
// {
//     Console.WriteLine("Результат перемножения матриц ");
//     int[,] ResultArray = new int[AArray.GetLength(0), ВArray.GetLength(1)];

//     for (int i = 0; i < AArray.GetLength(0); i++)

//     {
//         for (int j = 0; j < ВArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < AArray.GetLength(1); k++)
//             {
//                 ResultArray[i, j] = ResultArray[i, j] + AArray[i, k] * ВArray[k, j];
//             }
//             Console.Write($"{ResultArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     //return ResultArray;
// }
// MultiplicationArray(AArray, ВArray); // Вызов метода перемножения матриц


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

int[,,] CreatureRandomArray(int rows, int column, int cub, int min, int max) // Метод формирования трехмерного массива
{
    int[,,] array = new int[rows, column, cub];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int l = 0; l < cub; l++)
            {
                int numbers = new Random().Next(min, max + 1);

                for (int i1 = 0; i1 < i; i1++) // проверка элемента на повтор
                {
                    for (int j1 = 0; j1 < j; j1++)
                    {
                        for (int l1 = 0; l1 < l; l1++)
                        {
                            if (array[i, j, l] == numbers)
                            {
                                continue;
                            }
                        }
                    }
                }
                array[i, j, l] = numbers;
                Console.Write($" {array[i, j, l]} ( {i}, {j}, {l} )" );
            }
        }
        Console.WriteLine();
    }
    return array;
}

Console.Write("Задайте количество элементов в строке: ");  
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество элементов в столбце: ");  
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество элементов в третьем измерении: ");  
int o = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве от: ");  
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве до: ");  
int max = Convert.ToInt32(Console.ReadLine());

int[,,] AArray = CreatureRandomArray(n, m, o, min, max); // Формирование матрицы 1
Console.WriteLine();
