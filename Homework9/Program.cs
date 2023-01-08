// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void Numback (int num)
{
    if(num>=1) {Console.Write($"{num} "); Numback(num-1);}
}

Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
Numback(num);
*/

// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void Check (int m, int n)
{
    int k = n;
    if(m > n) {n = m; m = k; Console.Write(SumNum(m,n));}
    else Console.Write(SumNum(m,n)); 
}

int SumNum (int m, int n)
{
    if(m <= n) return SumNum (m, n-1) + n;
    else return 0;
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Check(m,n);
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
	if(m == 0) return n + 1;
	if(m > 0 && n == 0) return Akkerman(m - 1, 1);
	return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(m, n));
*/
