// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a,int b,int c)
{
    if(a + b > c && b + c > a && a + c > b) return true;
    else return false;
}

Console.Write("Введите длину первой сторону: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй сторону: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей сторону: ");
int c1 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(a1,b1,c1);
Console.WriteLine(result);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fib (int size, int a, int b)
{
    int[] array = new int [size];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < size; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fib(number, num1, num2);

WriteArray(myArray);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] CrArray(int size, int max, int min) // int[] CrArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1); // array[i] = new Random().Next();
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

int[] NewArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for(int i = 0; i < array.Length; i++) 
    {
        newarray[i] = array [i];
    }
    return newarray;
}

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CrArray(number, max1, min1);
WriteArray(myArray);
int[] newArray = NewArray(myArray);
myArray[myArray.Length - 1] += 10;
WriteArray(newArray);
WriteArray(myArray);
*/