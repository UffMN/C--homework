//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
bool Pal (int N)
{
    int A = N % 100 / 10;
    int B = N % 10;
    int C = A + B * 10;
    int D = N / 1000; 
    if (C == D)
    {
        return true;
    }
    else return false;
}

Console.WriteLine("Writer your number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pal (N));
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
Console.WriteLine("X1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("X2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(Math.Round(dist, 2));
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
/*
Console.WriteLine("Writer your number: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
do
{
Console.Write (Math.Pow(c,3) + " ");
c++;
}
while (c <= b);
*/