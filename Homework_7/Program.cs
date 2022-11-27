// === Задача 47 ===
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Clear();

Console.WriteLine("The program makes 2D array consist of rational numbers");
Console.WriteLine();

double[,] CreateRand2DDoubleArray(int rows, int colomns, int minValue, int maxValue)
{
    double[,] array = new double[rows, colomns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colomns; j++)
           array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 3); 
    return array; 
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
             Console.Write(array[i, j] + " ");  
        
        Console.Write("\n");  
    }
    Console.Write("\n");          
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
        double[,] array = CreateRand2DDoubleArray(r, c, min, max);
        Show2DArray(array);
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");

    */


// === Задача 47 ===
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Clear();

Console.WriteLine("The program takes the position of element of the 2D array and returns the value of the element");
Console.WriteLine();

int[,] CreateRandom2DArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] array = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colomns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

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

int[] FindElement(int r_num, int c_num, int[,] array)
{
    int[] ArrayVal = new int[2] {0, 0};

    if (r_num <= (array.GetLength(0)) && c_num <= (array.GetLength(1)))
    {
        ArrayVal[0] = array[r_num - 1, c_num - 1];
        return ArrayVal;
    }
    else
    {
        ArrayVal[1] = -1;
        return ArrayVal;
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
        Console.Write("Input the row's number of element:");
        int rNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the colomn's number of element:");
        int cNum = Convert.ToInt32(Console.ReadLine());
        int[] ArrayVal = new int[2];
        ArrayVal = FindElement(rNum, cNum, array);
        if (ArrayVal[1] == -1)
            Console.Write("There is no such row or colomn");
        else
            Console.Write($"The number in {rNum} and {cNum} position is {ArrayVal[0]}");
    
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");

*/

// === Задача 52 ===
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце..


Console.Clear();

Console.WriteLine("The program finds arithmetical mean of numbers in each colomn");
Console.WriteLine();


int[,] CreateRandom2DArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] array = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colomns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

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

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

double[] ArithMean(int[,] array)
{
   double[] array2 = new double[array.GetLength(1)];
   double sum;
   

   for (int i = 0; i < array.GetLength(1); i++)
   {
    
    sum = 0;  
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];         
        }
    array2[i] = sum / array.GetLength(0);
   }

   return array2;
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
        double[] array2 = ArithMean(array);
        Console.Write("The arithmetical mean of numbers in each colomn is ");
        ShowDoubleArray(array2);
    }
    else
        Console.WriteLine("Amount of rows or columns is less then 0");
}
else
    Console.WriteLine("Minimum possible value is bigger then maximum possible value");