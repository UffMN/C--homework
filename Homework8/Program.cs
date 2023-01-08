// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Cr2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
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

void Adj2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int x = 0; x < array.GetLength(1)-1; x++)
                if(array[i,x] < array[i,x+1]) // Если аргумент 0 позиции меньше чем аргумент 1, то
                {
                    int adj = array[i,x+1]; // Создаем аргумент adj, который приравниваем к значению аргумента 1
                    array[i,x+1] = array[i,x]; // Значение аргумента 1 приравниваем к аргументу 0, так как в случае если if true аргумент 0 меньше аргумента 1 и их необходимо поменять местами
                    array[i,x] = adj; // Переносим значение аргумента 1 на позицию аргумента 0 (всегда на позицию аргумента 0 в связи с чем, что по условию оно будет больше всех предыдущих)
                }
}

int[,] myArray = Cr2dArray();
Show2dArray(myArray);
Adj2dArray(myArray);
Show2dArray(myArray);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] Cr2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
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

int[] CrSum2dArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int z = 0;
    int sum = 0;
    int[] array2 = new int [array.GetLength(0)];
    while(i < array.GetLength(0))
    {
        j = 0;
        sum = 0;
        while(j < array.GetLength(1))
        {
            sum += array[i,j];
            j++;
        }
        array2[z] = sum;
        i++;
        z++;
    }
//    z = 0;
//    while(z < array.GetLength(0))
//    {
//    Console.Write($"{array2[z]} ");
//    z++;
//    }
    return array2;
}

void ShowSumArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int Min (int[] array)
{
    int min = array[0];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            count = i;
        }
    }
    return count;
}

int[,] myArray = Cr2dArray();
Show2dArray(myArray);
int[] arraytotal = CrSum2dArray(myArray);
ShowSumArray(arraytotal);
int min = Min(arraytotal);
Console.WriteLine($"Строка с наименьшей суммой элементов - {min + 1}");
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int mini = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int maxi = Convert.ToInt32(Console.ReadLine());

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

void ResultMX(int[,] array1, int[,] array2, int[,] resultmx)
{
    for (int i = 0; i < resultmx.GetLength(0); i++)
        for (int j = 0; j < resultmx.GetLength(1); j++)
        {
            int sum = 0;
            for (int z = 0; z < array1.GetLength(1); z++)
                sum += array1[i, z] * array2[z, j];
            resultmx[i, j] = sum;
        }
}

int[,] result = new int[row, column];
int[,] myArray = Cr2dArray(row, column,mini,maxi);
Show2dArray(myArray);
int[,] myArray2 = Cr2dArray(row, column,mini,maxi);
Show2dArray(myArray2);
ResultMX(myArray, myArray2, result);
Console.WriteLine("Произведение матриц:");
Show2dArray(result);
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
Console.Write("Введите размер массива по X: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива по Y: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива по Z: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,,] Change3MArray (int [,,] array)
{
    int[] arrayline = new int[rows * columns * width];
    int value;
    for (int i = 0; i < arrayline.GetLength(0); i++)
    {
        arrayline[i] = new Random().Next(10, 100);
        value = arrayline[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arrayline[i] == arrayline[j])
                {
                    arrayline[i] = new Random().Next(10, 100);
                    j = 0;
                    value = arrayline[i];
                }
                value = arrayline[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = arrayline[count];
                count++;
            }
    }
return array;
}

void Show3MArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i,j,k]} {(i, j, k)}");
        }
    }
    Console.WriteLine();
}

int[,,] myArray = new int[rows, columns, width];
int[,,] changed3Marray = Change3MArray(myArray);
Show3MArray(changed3Marray);
*/


// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Change2dArray (int[,] array)
{
int temp = 1;
int i = 0;
int j = 0;
while (temp <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) - 1) i++;
    else if (i >= j && i + j > array.GetLength(1) - 1) j--;
    else i--;
}
return array;
}

Console.Write("Введите ширину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = new int[n, n];
Change2dArray(myarray);
WriteArray(myarray);
*/