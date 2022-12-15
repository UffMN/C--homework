// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
for(int n = 1; n < b; n++) c *= a;
Console.WriteLine(c);
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum (int c)
{
    int n = 1;
    int sum = 0;
    while (c >= 1)
    {
        n = c % 10;
        sum +=  n;
        c /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {SumNum(a)}");
*/
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CrArray(int size) // int[] CrArray(int size, int max, int min)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(); // array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}"); //Console.Write(array[i] + " ");
    }
}

WriteArray(CrArray(8));
*/

//Console.Write("Введите размер массива: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите максимальное число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите минимальное число: ");
//int c = Convert.ToInt32(Console.ReadLine());
//WriteArray(CrArray(a, b, c));