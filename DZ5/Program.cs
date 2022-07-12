// Домашнее задание 5. Решение всех задач по одному массиву

int[] CreatureRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }

        else
        {
            Console.Write(array[i] + " ]");
        }
    }
    Console.WriteLine();
}

void EvenArray(int[] array)         // Метод нахождение количества чётных чисел в массиве (ЗАДАЧА 34)
{
    int quantity = 0;

    for (int i = 0; i < array.Length; i++)
    {
        double ostatok = array[i] % 2;

        if (ostatok == 0)
        {
            quantity++;
        }
    }
    Console.WriteLine($" {quantity}");
}

void OddArray(int[] array)          // Метод нахождение суммы элементов, стоящих на нечётных позициях (ЗАДАЧА 36)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];

    }
    Console.WriteLine($" {sum}");
}

void MinMaxArray(int[] array)       // Метод нахождение разницы между максимальным и минимальным элементами матрицы (ЗАДАЧА 38)
{
    int elem_max = 0;
    int elem_min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (elem_min > array[i])
        {
            elem_min = array[i];
        }
        else
        {
            if (elem_max < array[i])
            {
                elem_max = array[i];
            }
        }
    }

    Console.WriteLine($" MAX элемент массива = {elem_max}, MIN элемент массива = {elem_min}");
    Console.WriteLine($"Разница между MAX и MIN элементами массива: {elem_max - elem_min}");
}

Console.Write("Введите размер массива: ");  
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве от: ");  
int mina = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте диапазон элементов в массиве до: ");  
int maxa = Convert.ToInt32(Console.ReadLine());


int[] AArray = CreatureRandomArray(n, mina, maxa);
Console.WriteLine();
PrintArray(AArray);
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве (ЗАДАЧА 34): ");
EvenArray(AArray);   // Вызов метода нахождение количества чётных чисел в массиве (ЗАДАЧА 34)
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечётных позициях (ЗАДАЧА 36): ");
OddArray(AArray);    // Вызов метода нахождение суммы элементов, стоящих на нечётных позициях (ЗАДАЧА 36)
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами матрицы (ЗАДАЧА 38): ");
MinMaxArray(AArray); // Вызов метода нахождение разницы между максимальным и минимальным элементами матрицы (ЗАДАЧА 38)
Console.WriteLine();