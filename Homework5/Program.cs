// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CrArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000); // array[i] = new Random().Next();
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int Nnum (int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) n++;
    }
    return n;
}

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = CrArray(number);
WriteArray(myArray);
int X = Nnum(myArray);
Console.Write($" - в массиве {X} четных чисел");
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CrArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); // array[i] = new Random().Next();
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int Sum (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) 
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] myArray = CrArray(number, a, b);
WriteArray(myArray);
int total = Sum(myArray);
Console.Write($" - сумма числе на нечетных позициях {total}");
*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CrArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100) + new Random().NextDouble();
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],2) + " ");
    }
}

double Min (double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
    }
    return min;
}

double Max (double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
    }
    return max;
}

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] myArray = CrArray(number);
WriteArray(myArray);
double min = Min(myArray);
double max = Max(myArray);
Console.Write($"\nМаксимальное значение {Math.Round(max,2)}, Минимальное значение {Math.Round(min,2)}, Разница между ними {Math.Round(max,2) - Math.Round(min,2)}");
*/