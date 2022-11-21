// === Задача 34 ===
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Clear();

Console.WriteLine("The program shows amount of even numbers in the array consist of 3 digits");
Console.WriteLine();

int[] CreateRandom3DArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)
{
    int k = 1;
    Console.Write("The array is: ");
    Console.Write("\n");  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
        if (k % 10 == 0)
            Console.Write("\n"); 
        k++; 
    }
    Console.Write("\n");  
}

int EvenAmmount(int[] array)
{
    int ev = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            ev++; 
    return ev;
}

Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandom3DArray(size);
ShowArray(array);
Console.WriteLine();
Console.Write("Ammount of even numbers is: " + EvenAmmount(array));
*/

// === Задача 36 ===
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Clear();

Console.WriteLine("The program calculate the sum of elements that are in the odd positions");
Console.WriteLine();

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");  
    Console.Write("\n");  
}

int SumOfOddPos(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i != 0 && i % 2 != 0)
           sum =  sum + array[i];
    }
    return sum;
}

Console.Write("Input the number of elements:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(n, min, max);
ShowArray(MyArray);

Console.Write("The sum of elements that are in the odd positions is: " + SumOfOddPos(MyArray));

*/// === Задача 36 ===
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.Clear();

Console.WriteLine("The program calculate the sum of elements that are in the odd positions");
Console.WriteLine();

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 3);
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");  
    Console.Write("\n");  
}

double Differ(double[] array)
{
    double MinVal = array[0], MaxVal = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < MinVal) 
            {
                MinVal = array[i];
            }
             if (array[i] > MaxVal) 
            {
                MaxVal = array[i];
            }
        }
    
    Console.Write("\n");
    Console.Write(MaxVal);
    Console.Write("\n");
    Console.Write(MinVal);
    Console.Write("\n");
    return MaxVal - MinVal;
}

Console.Write("Input the number of elements:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

double[] MyArray = CreateRandomArray(n, min, max);
ShowArray(MyArray);

Console.Write("The difference between the biggest and the smallest elements of array is: " + Differ(MyArray));
