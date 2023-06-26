// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int startNum = 1;

// System.Console.WriteLine(PrintNumbers(num, startNum));

// string PrintNumbers(int num1, int num2)
// {
//     if (num1==num2)
//     {
//         return num1.ToString();
//     }

//     return (num1+ " " + PrintNumbers(num1-1, num2));
// }



// ***************************************************************************************



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




// Console.WriteLine("Введите минимальное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Сумма чисел в промежутке от M до N:");

// Console.WriteLine(PrintNum(num,number));

// int PrintNum(int num1, int num2)
// {
//     if (num1==num2)
//     {
//         return num1;
//     }
//     return (num1 + PrintNum(num1+1, num2));
// }



// ******************************************************************************




// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

