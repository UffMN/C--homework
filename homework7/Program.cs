// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Cr2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j],2) + " ");
        Console.WriteLine(); // Создание новой строки для массива
    }
    Console.WriteLine(); 
}


double[,] myArray = Cr2dArray();
Show2dArray(myArray);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Cr2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowPosition(int[,] array, int a, int b)
{
    if(a <= array.GetLength(0) && b <= array.GetLength(1)) Console.WriteLine($"На позиции ({a},{b}) в массиве {array[a - 1,b - 1]}");
    else Console.WriteLine($"На позиции ({a},{b}) в массиве нет числа");
}



Console.Write("Введите номер строки: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер элемента в строке: ");
int b1 = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Cr2dArray(4, 4, 1, 10);
Show2dArray(myArray);
ShowPosition(myArray, a1, b1);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Cr2dArray()
{
    int rows = 4;
    Console.WriteLine($"Количество строк: {rows}");
    int columns = 6;
    Console.WriteLine($"Количество столбцов: {columns}");
    int min = 1;
    Console.WriteLine($"Минимальное число: {min}");
    int max = 10;
    Console.WriteLine($"Максимальное число: {max}");
     Console.WriteLine();
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
    double average = 0;
    double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];            
        }
    average = sum / array.GetLength(0);
    Console.Write($"({Math.Round(average,2)}) ");
}
}

int[,] myArray = Cr2dArray();
Show2dArray(myArray);
Average(myArray);
*/








// что-то не рабочее
/*
void ShowPosition(int[,] array, int a, int b, int min)
{
    string position = Convert.ToString(array[a - 1,b - 1]);
    if(position != string.Empty && array[a - 1,b - 1] > min) Console.WriteLine(array[a - 1,b - 1]);
    else Console.WriteLine("nothing");
}
*/