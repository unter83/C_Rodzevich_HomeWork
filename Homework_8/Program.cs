void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.Write("\n");
    }
    Console.Write("\n");
}

int[,] CreateRandom2DArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] array = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colomns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


// === Задача 54 ===
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Clear();

Console.WriteLine("The program sorts each row of the 2D array from larger to smaller number");
Console.WriteLine();




void ConvertArray(int[,] array)
{
    
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(1))
                {
                    if (array[i,k] < array[i,j])
                        {
                            int temp =  array[i,k];
                            array[i,k] = array[i,j];
                            array[i,j] = temp;      
                        }
                    k++;
                }      
        }        
    }    
}

Console.Write("Input the min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

if (min <= max)
{
    Console.Write("Input the number of rows:");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of colomns:");
    int c = Convert.ToInt32(Console.ReadLine());
    if (r > 0 && c > 0)
    {
        int[,] array = CreateRandom2DArray(r, c, min, max);
        Show2DArray(array);
        Console.WriteLine("");
        ConvertArray(array);
        Show2DArray(array);
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");

*/

// === Задача 56 ===
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.WriteLine("The program shows a number of row if 2D array with the smallest sum of its elements");
Console.WriteLine();

int NumOfSmallSumRow(int[,] array)
{
    int[] sum_array = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum_array[i] += array[i,j];
        
    int min_sum = sum_array[0], min_index = 0;

    for (int i = 1; i <  sum_array.Length; i++)
        if (sum_array[i] < min_sum)
        {
            min_index = i;
            min_sum = sum_array[i];
        }
    return min_index;
}

Console.Write("Input the min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

if (min <= max)
{
    Console.Write("Input the number of rows:");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of colomns:");
    int c = Convert.ToInt32(Console.ReadLine());
    if (r > 0 && c > 0)
    {
        int[,] array = CreateRandom2DArray(r, c, min, max);
        Show2DArray(array);
        Console.WriteLine("");
        Console.Write("The row with the smallest sum of its elements is: " + (NumOfSmallSumRow(array) + 1));
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");
