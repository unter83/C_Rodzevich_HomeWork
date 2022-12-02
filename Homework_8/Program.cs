void Show2DArray(int[,] array)
{
    int max = array[0, 0];   // Определение максимального числа матрице //
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (Math.Abs(array[i, j]) > max)
                max = Math.Abs(array[i, j]);

    int div = max, max_digit = 1; // Определение разрядности максимального числа матрице //
    while (div > 0)
    {
        div = div / 10;
        max_digit++;
    }


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int count = 0;
            div = Math.Abs(array[i, j]);

            while (div > 0)
            {
                div = div / 10;
                count++; // <------- Считает разрядность числа в масиве 
            }

            count = max_digit - count; // Определяем сколько пробелов поставить перед числом           
            if (array[i, j] == 0)
                count--;
            if (array[i, j] < 0)
                count--;

            while (count > 0) // Расставляем пробелы    
            {
                Console.Write(" ");
                count--;
            }

            Console.Write(array[i, j] + " ");
        }
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
/*
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

*/
// === Задача 57 ===
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int [,] ProdMatrix(int [,] arrayA, int [,] arrayB)
{
    int[,] prod_array = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int m = 0; m < prod_array.GetLength(0); m++)
        for (int n = 0; n < prod_array.GetLength(1); n++)
        {   
            int sum = 0;
            for (int i = 0, j = 0; i < arrayA.GetLength(1) && j < arrayB.GetLength(0); i++, j++)
                {
                    sum = sum + arrayA[m,i] * arrayB[j,n];
                }
            prod_array[m,n] = sum;
        }       

    return prod_array;
}


Console.Clear();

Console.WriteLine("The program shows a product of two arrays");
Console.WriteLine();

Console.Write("Input the min possible value for both arrays:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value for both arrays:");
int max = Convert.ToInt32(Console.ReadLine());

if (min <= max)
{
    Console.Write("Input the number of rows for first array:");
    int r1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of colomns for first array:");
    int c1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of rows for second array:");
    int r2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of colomns for second array:");
    int c2 = Convert.ToInt32(Console.ReadLine());
    if (r1 > 0 && c1 > 0 && r2 > 0 && c2 > 0)
    {
        int[,] arrayA = CreateRandom2DArray(r1, c1, min, max);
        int[,] arrayB = CreateRandom2DArray(r2, c2, min, max);
        Console.WriteLine("");
        Console.WriteLine("First matrix:");
        Show2DArray(arrayA);
        Console.WriteLine("");
        Console.WriteLine("Second matrix:");
        Show2DArray(arrayB);   
        if (arrayA.GetLength(1) == arrayB.GetLength(0))
        {
            int[,] prod_array = ProdMatrix(arrayA, arrayB);
            Console.WriteLine("");
            Console.WriteLine("Production of first and second matrix is:");
            Show2DArray(prod_array);
        }
        else
            Console.WriteLine("Number of colomns of the firts array and rows of the second array must be equal");
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");
*/

// === Задача 60 ===
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*

int[,,] CreateRandom3DArray(int v1, int v2, int v3)
{
    int[,,] array = new int[v1, v2, v3];
    int[] array_string = new int[v1 * v2 * v3];
    int n = 0;
    for (int i = 0; i < v1; i++)
        for (int j = 0; j < v2; j++)
            for (int k = 0; k < v3; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                array_string[n] = array[i, j, k];
                int count = 0;
                while (count < n)
                {
                    if (array[i, j, k] == array_string[count])
                    {
                        array[i, j, k] = new Random().Next(10, 100);
                        array_string[n] = array[i, j, k];
                        count = 0;
                    }
                    else
                        count++;
                }
                n++;
            }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

}

void ShowArrayAndIndexes(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)            
                Console.Write(array[i,j,k] + " (" + i + "," + j + "," + k + ") ");
            Console.Write("\n");   
        }

}

Console.Clear();

Console.WriteLine("The program makes 3D array with unique 2-digit numbers and shows its elements with indexes");
Console.WriteLine();

Console.Write("Input a length of the 3D array:");
int v1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a width of the 3D array:");
int v2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a depth of the 3D array:");
int v3 = Convert.ToInt32(Console.ReadLine());
if (v1 > 0 && v2 > 0 && v3 > 0)
{
    if (v1 * v2 * v3 < 89)
    {
        int[,,] array = CreateRandom3DArray(v1, v2, v3);
        Console.WriteLine("");
        ShowArrayAndIndexes(array);
    }
    else
        Console.WriteLine("There must be less then 90 elements in the array");
}
else
    Console.WriteLine("Amount of rows or columns is less then 0");

*/
// === Задача 60 ===
// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] GenerateSpiralArray(int rows, int colomns)
{
    int[,] array = new int[rows, colomns];
    int count = 0;
    int i = 0, j = 0;
    int mr = 0;
    while (count < rows * colomns)
    {
        while (j < colomns - mr)
        {
            array[i, j] = count;
            j++;            
            count++;
        }
        j--;     
        i++;
        while (i < rows - mr)
        {
            array[i, j] = count;
            i++;
            count++;           
        } 
        i--;
        j--;
        

        while (j > (-1 + mr))
        {
            array[i, j] = count;
            j--;
            count++;
        }
        i--;
        j++;
        mr++;

        while (i > (-1 + mr))
        {
            array[i, j] = count;
            i--;
            count++;
        }
        i++;
        j++;
    }
    return array;
}

Console.Clear();

Console.WriteLine("The program makes spiral 2D array");
Console.WriteLine();

Console.Write("Input the number of rows:");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of colomns:");
int c = Convert.ToInt32(Console.ReadLine());
if (r > 0 && c > 0)
{
    int[,] array = GenerateSpiralArray(r, c);
    Show2DArray(array);
    Console.WriteLine("");
}
else
    Console.WriteLine("Amount of rows or columns is less then 0");
