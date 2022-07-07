
// // Задание 19. Определить является ли число палиндромом 

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(number);  //преобразование числа в строку
// int col = s.Length;    // определение значности числа

// int[] AArray; // полученное от пользователя число запоминаем в массив
// AArray = new int[col];

// for (int i = 1; i < col; i++)
// {
//     int x = (int)Math.Pow(10, col - i);
//     int a = number / x % 10;
//     AArray[i] = a;
//     Console.Write(" " + AArray[i]);
// }    
//     int b = number % 10;
//     AArray[col - 1] = b;
//     Console.WriteLine(" " + AArray[col - 1]);

// int sum = 0; // не могу понять в чем ошибка - предпоследнее число упорно не выводится - перескакивает, а в место него добавляетcя 0
// for (int i = 0; i < col; i++)
// {
//     int x = (int)Math.Pow(10, (col - 1) - i);
//     sum = sum + x * (AArray[(col - 1) - i]);
// }
// Console.WriteLine(sum);

// if (sum == number)
// {
//     Console.WriteLine($"Число  {number}  является палиндромом");
// }
//  else {Console.WriteLine($"Число  {number}  не является палиндромом");}


// -------------
// // Задача 23. Возведение чисел от 1 до N в заданную степень

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int s = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Таблица возведения чисел от 1 до {n} в степень {s}: ");

// for (int i = 1; i <= n; i++)
// {
//    Console.Write($" {Math.Pow(i, s)} ");
// }
// Console.WriteLine();


// // ----------------
// // Задача 21. Поиск расстояния между двумя точками в 3D-пространстве.

int[] AArray;
AArray = new int[3];

Console.Write("Введите координаты точки А: ");
for (int i = 0; i < 3; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        AArray[i] = number;
    }

int[] BArray;
BArray = new int[3];

Console.Write("Введите координаты точки B: ");
for (int i = 0; i < 3; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    BArray[i] = number;
}
Console.WriteLine();

 double raznost = 0;
 double kvadrat = 0;
 double summa = 0;
 double dlina = 0;

 for (int i = 0; i < 3; i++)
 {
 raznost = BArray[i] - AArray[i];
 kvadrat = Math.Pow(raznost, 2);
 summa = summa + kvadrat;
  }
 dlina = Math.Sqrt(summa);

Console.Write("Координаты точки А: ");
for (int i = 0; i < 3; i++)
{ Console.Write($" {AArray[i]} "); }
Console.WriteLine();

Console.Write("Координаты точки B: ");

for (int i = 0; i < 3; i++)
{ Console.Write($" {BArray[i]} "); }
Console.WriteLine();
Console.WriteLine($"Расстояние между точками А и В = {dlina}");



