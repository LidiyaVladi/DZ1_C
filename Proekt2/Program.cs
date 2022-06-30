// Поиск большего и наименьшего:

/* Console.Write("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}
*/


// Поиск максимального числа:
int i = 1;
Console.Write("Введите кол-во чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
int max = 0;

while (i <= N)
{
    Console.Write("Введите число ");
    Console.Write(i);
    Console.Write(": ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (max < a)
        {
            max = a;
        }
i = i + 1;
}
Console.Write("max = ");
Console.WriteLine(max); 

