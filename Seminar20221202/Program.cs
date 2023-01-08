/*
int CutNubmber(int num)
{
    int ed = num % 10;
    int ten = num / 10;
    return ed;
    return ten;
}

int RN = new Random().Next(10, 100);
int max = ed;
if (max < ten) ten = max;

Console.Write(max);
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
/*
int FindMax (int num)
{
    int first = num / 10;
    int second = num % 10;
    if (first > second) return first;
    else return second;
}

int random = new Random().Next(10,100);
int result = FindMax(random);
Console.WriteLine($"The number is {random} and the result is {result}")
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool IsDiv (int number, int firstDiv, int secondDiv)
{
    if (number%firstDiv == 0 && number%secondDiv == 0) return true;
    else return false;
}

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your first divided: ");
int firstDiv = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second divided: ");
int secondDiv = Convert.ToInt32(Console.ReadLine());

bool boolCheck = IsDiv(number, firstDiv, secondDiv);

Console.WriteLine(boolCheck);
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool IsSquare (int firstNum, int secondNum)
{
    if (firstNum / secondNum == secondNum || secondNum / firstNum == firstNum)
    {
        return true;
    }
    else return false;
}

Console.WriteLine("Writer your first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Writer your second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare (firstNumber, secondNumber));
*/