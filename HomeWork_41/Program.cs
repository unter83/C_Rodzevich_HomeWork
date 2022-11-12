// === Задача 25 ===
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Power(int bs, int exp)
{
    if (exp < 0)
    {
        return -1;
    }
     if (exp == 0)
    {
        return 1;
    }
    int count = 1, mult = 1;
    while (count <= exp)
    {
        mult = mult * bs;
        count++;
    }
    return mult;
}

Console.Clear();

Console.WriteLine("The program the exponentiation of digit A raised to the power of B");
Console.WriteLine();

Console.Write("Input the base A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the power B: ");
int pw = Convert.ToInt32(Console.ReadLine());

int exp = Power(num, pw);
if (exp == -1)
    Console.WriteLine("The power must be more then zero");
else
Console.WriteLine($"{num} raised to the power of {pw} is " + exp);
*/

// === Задача 27 ===
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();

Console.WriteLine("The program shows the sum of digits in the number");
Console.WriteLine();

int SumOfDigits(int number)
{
    int dozen = 1, capacity = 0;

    while (Math.Abs(number / dozen) >= 1) // считаем количество чисел и разряд
    {
        dozen = dozen * 10;
        capacity++;
    }
    int digit = 0, count = 0, sum = 0;
    for (count = 0; count <= capacity; count++)
    {
        digit = Math.Abs((number / dozen) % 10); // выделяем цифру
    //  Console.WriteLine(digit);
        dozen = dozen / 10;
        sum = sum + digit;
    }
    return sum;  
}

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"The sum of all digits is {SumOfDigits(num)}");
*/

// === Задача 29 ===
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

string[] StringToArray(string string_of_chars)
{
   
    // Определение ёмкости массива 
    int space_ammount = 0;
    for (int i = 0; i < string_of_chars.Length; i++) 
    {
        if (string_of_chars[i] == ' ')
        {
            space_ammount++;         
        }  
    }    

    // Формирование массива строк
    string[] array_of_strings = new string[space_ammount + 1]; 
    string number = "";
    int j = 0;
    for (int i = 0; i < string_of_chars.Length; i++) 
    {
        if (string_of_chars[i] != ' ')
        {
            number = number + string_of_chars[i];
            array_of_strings[j] = number;
        }
        else
        {
            j++;
            number = "";
        }
    }

 
    // Чистим массив от нулевых строк 
    string[] new_array_of_strings = new string[space_ammount + 1]; 
    j = 0;
    for (int i = 0; i < array_of_strings.Length; i++) 
        if (array_of_strings[i] != null)
        {
           new_array_of_strings[j] = array_of_strings[i];
           j++;
        }
 
    Array.Resize(ref new_array_of_strings, j);

    return new_array_of_strings;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($" The {i} element of the array is {array[i]}");

}

Console.Write("Input the array of strings. Divide the strings using space: ");
string digits = Console.ReadLine();
if (digits.Length == 0)
{
    Console.WriteLine("You didn't input any symbol");
}
else
{
    string[] array_of_string = StringToArray(digits);
    ShowArray(array_of_string);

    Console.WriteLine("");
    Console.Write($"The length of the array is {array_of_string.Length}");
}
