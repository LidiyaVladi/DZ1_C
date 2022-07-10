// // ЗАДАЧА 25. Цикл, который принимает на вход два числа (А и В) и врзводит число А в натуральную степень В.

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int expo = A;
//     for (int i = 0; i < B-1; i++)
//         {
//             expo = expo * A;
//         }
// Console.WriteLine($"Число {A} в степени {B} => {expo}");


// //  ЗАДАЧА 27. Программа, которая принимает на вход число и выдает сумму цифр в числе.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(number);  //преобразование числа в строку
// int col = s.Length;

// int sum = 0; 
// int x = 0;

// if (number < 0)
//     {
//      x = number * (-1);
//     }
// else { x = number; }

// for(int i = 0; i <= col; i++)
//     {
//         sum = sum + x%10;
//         x = x/10;  
//     }  
// Console.WriteLine($"Сумма цифр числа {number} -> {sum} ");


//  ЗАДАЧА 29. Программа задает массив из 8 элементов и выводит их на экран

// Console.Write("Введите длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

int n = 8;
int[] AArray;
AArray = new int[n];

Console.Write("[");
for (int i = 0; i < n; i++)
{
    AArray[i] = new Random().Next(1,1000);

    if(i != n-1)
        {
            Console.Write(AArray[i] + ", ");
        }
    else 
        { 
            Console.Write(AArray[i] + "]");
        }
}
Console.WriteLine();
