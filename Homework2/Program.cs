// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* 
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = (num - sot * 100 - ed) / 10;
    return result;
}
Console.WriteLine("Введите трехзначное натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newnum = CutNumber(num);
Console.WriteLine($"Вторая цифра заданного числа: {newnum}");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumber(int i)
{
    int a = i % 10;
    return a;
}
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num;
if (100 - num > 0) Console.WriteLine("Третье цифры нет");
else 
{
    do
        {
            i = i / 10;
        }
        while (999 - i < 0);
int newnum = CutNumber(i);
Console.WriteLine($"Третья цифра заданного числа: {newnum}");
}
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Days (int N)
{
    if (N - 5 > 0 && N <= 7)
    {
        return true;
    }
    else return false;
}

Console.WriteLine("Writer your first number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Days (N));
*/