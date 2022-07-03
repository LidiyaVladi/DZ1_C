// // Домашнее задание 1 (3 и 4 задачи) и Домашнее задание 2

// // Домашнее задание 1. Задача 6. Определение, число четное или нечетное

//  Console.Write( "Введите целое число: " );
//  int a = Convert.ToInt32(Console.ReadLine());
//  double ostatok = a % 2;
//       if (ostatok == 1 || ostatok == -1)
//           {
//             Console.WriteLine("Число " + a + " - нечетное");
//           }
//       else Console.WriteLine("Число " + a + " - четное");


// // -------------------------------------------------------------------------------------------------
// // Домашнее задание 1. Задача 8. Вывод четных чисел с 1 до N

// Console.Write( "Введите число: " );
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 0;
   
// while (i <= n)
//     {  
//         if (i != 0)
//             {   
//                 Console.Write(" " + i);
//                 i=i+2;
//             }
//         else 
//             {   
//                 i=i+2;
//             }
//     }
// Console.WriteLine();


// // -------------------------------------------------------------------------------------------------
// // Определение дня недели по числу

// Console.WriteLine( "Введите число: " );
// int a = Convert.ToInt32(Console.ReadLine());

// if(a > 0 && a <= 7)
// {
// if(a == 1) { Console.WriteLine("Понедельник");}
// if(a == 2) { Console.WriteLine("Вторник");}
// if(a == 3) { Console.WriteLine("Среда");}
// if(a == 4) { Console.WriteLine("Четверг");}
// if(a == 5) { Console.WriteLine("Пятница");}
// if(a == 6) { Console.WriteLine("Суббота");}
// if(a == 7) {Console.WriteLine("Воскресенье");}
// }
//  else {Console.WriteLine("Ошибка - в неделе 7 дней");}

// // -------------------------------------------------------------------------------------------------
// // Домашнее задание 2. Задача 10. Вывод второй цифры из трехзначного числа

// Console.Write( "Введите трехзначное число: " );
// int number = Convert.ToInt32(Console.ReadLine()); 

// if(number < 0)
//     {
//         number = number * (-1);
//     }

//     if(number > 99 && number < 1000)
//         { 
//             int num1 = number/10;
//             int num2 = num1%10;
//             Console.WriteLine(num2);
//         }
//     else 
//         {
//             Console.WriteLine( "Ошибка. Введите трехзначное число" );
//         }
// // как переправить программу на начало - на ввод числа? - надо создать метод ввода данных?


// // -------------------------------------------------------------------------------------------------
// // Домашнее задание 2. Задача 15. Определение по числу - будни / выходной

// Console.WriteLine( "Введите число: " );
// int a = Convert.ToInt32(Console.ReadLine());

// if(a > 0 && a <= 7)
//     {
//         if(a >= 1 && a <= 5) { Console.WriteLine("будни");}
//         if(a == 6 || a == 7) { Console.WriteLine("выходной");}
//     }
// else {Console.WriteLine("Ошибка - в неделе 7 дней");}


// // -------------------------------------------------------------------------------------------------
// // Домашнее задание 2. Задача 13. Вывод третьей цифры числа

Console.Write( "Введите число: " );
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
    {
        number = number * (-1);
    }

if(number < 99)
        {
            Console.WriteLine("Ошибка. Вы ввели число, меньше трехзначного.");
        }
else    
    {

    if(number > 99 && number < 1000)
        { 
            int num1 = number%10;
            Console.WriteLine(num1);
        }
    
    if(number > 999 && number < 10000)
        { 
            int num1 = number/10;
            int num2 = num1%10;
            Console.WriteLine(num2);
        }
        
    if(number > 9999 && number < 100000)
        { 
            int num1 = number/100;
            int num2 = num1%10;
            Console.WriteLine(num2);
        }

    if(number > 99999 && number < 1000000)
        { 
            int num1 = number/100;
            int num2 = num1%10;
            Console.WriteLine(num2);
        }  
    }

 
