// === Задача 36 ===
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Clear();

Console.WriteLine("The program calculates how many positive numbers in the array");
Console.WriteLine();

// Переводим строку в массив отдельныъ элементов
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

// Показ массива
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($" The {i} element of the array is {array[i]}");

}

// Определение сколько положительных чисел

void PosNumbers (string[] array)
{
    int ammount = 0;
    double numVal;
        for (int i = 0; i < array.Length; i++)
            if (double.TryParse(array[i], out numVal))
            {
                //int.TryParse(array[i], out numVal);
                if (numVal > 0)
                    ammount++;
            }
    Console.WriteLine($"There are {ammount} of positive numbers");
}



// Основная программа
// ==================
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
    Console.WriteLine($"The length of the array is {array_of_string.Length}");
    
    PosNumbers(array_of_string);
}

*/


Console.Clear();

Console.WriteLine("The program calculates the intersection point of two lines");
Console.WriteLine();

Console.WriteLine("Input the multipliers for the first equation  y = k1 * x + b1: ");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Input the multipliers for the second equation  y = k2 * x + b2: ");
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;



if (k1 == k2 && b1 == b2)
    Console.WriteLine($"The lines are match");
else  
    if (k1 == k2)
        Console.WriteLine($"The lines are parallel");
    else
    {
        x = (b1-b2)/(k2-k1);
        y = k2 * x + b2;
        Console.WriteLine($"The intersection point of two lines is ({x}, {y})");
    }

