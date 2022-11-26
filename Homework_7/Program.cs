// === Задача 47 ===
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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