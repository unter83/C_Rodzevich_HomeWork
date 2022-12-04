// === Задача 64 ===
//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


/*
void ShowNaturalNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNaturalNumbers(n - 1);    
}


Console.Clear();

Console.WriteLine("The program shows all naturals numbers from N to 1");
Console.WriteLine();

Console.Write("Input N:");
ShowNaturalNumbers(Convert.ToInt32(Console.ReadLine()));

*/

// === Задача 66 ===
//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Clear();

Console.WriteLine("The program shows a sum foe all naturals numbers between N and M");
Console.WriteLine();

int SumBetweenTwoNum(int n, int m)
{
    if (n < m)
        return SumBetweenTwoNum(n + 1, m) + n;
    if (n > m)
        return SumBetweenTwoNum(n, m + 1) + m;
    return n;
}

Console.Write("Input N:");
int n = (Convert.ToInt32(Console.ReadLine()));
Console.Write("Input M:");
int m = (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
Console.Write($"The sum of numbers between {n} and {m} is {SumBetweenTwoNum(n,m)}");
*/

// === Задача 68 ===
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
        else
            if (m == 0)
                return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}


Console.Clear();

Console.WriteLine("The program calculates Ackermann function using recurtion for two positive numbers");
Console.WriteLine();

Console.Write("Input N:");
int n = (Convert.ToInt32(Console.ReadLine()));
Console.Write("Input M:");
int m = (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
if (n >= 0 && m >= 0)
{
    if (n >= 4)
        Console.WriteLine("Attention! N is more then 4. The function could rise very fast and may case stack overflow.");
    Console.WriteLine($"The Ackermann function A({n},{m}) = {Ackermann(n,m)}");
}
else
    Console.WriteLine("Enter two positive numbers");