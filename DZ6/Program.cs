//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int NumberPositiveNumbers(int size)    // Ввод чисел с клавиатуры
{
    int sum = 0;

    for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
                if (a > 0)
                 {
                     sum++;
                 }
        }
    if (sum > 0)  // Поиск количества чисел больше 0 
        {
            Console.WriteLine($"Чисел больше 0: {sum}");
        }
    else Console.WriteLine("Чисел больше 0 нет");

    return sum;
}

Console.Write("Определите количество вводимых чисел: ");  
int quantity = Convert.ToInt32(Console.ReadLine());
NumberPositiveNumbers(quantity);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2)
    { 
        Console.WriteLine("Прямые совпадают");  
    }
        else
           {
                if(k1 == k2)    Console.WriteLine("Прямые параллельны");
            else
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * x + b1;
                    Console.WriteLine($"Прямые пересекаются в точке ({x:f2}; {y:0.00})");
                }
            }

// задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    Console.Write($"Если N = {N} -> 0 1 ");
    int f1 = 0;
    int f2 = 1;

    for (int i = 0; i < N - 2; i++)
    {
        int f3 = f1 + f2;
        f1 = f2;
        f2 = f3;
        Console.Write($"{f3} ");
    }
}
else
{
    if (N == 1) { Console.Write($"Если N = {N} -> 0 "); }
    else
    {
        if (N == 2) { Console.Write($"Если N = {N} -> 0 1"); }
        else { Console.Write($"Задайте число больше 0"); }
    }
}
Console.WriteLine();

