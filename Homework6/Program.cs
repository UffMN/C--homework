// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Вводите ваши число по очереди, в конце введите stop.");
int count = 0;
int nums = 0;
string answer = "start";
while (answer != "stop")
{
    Console.Write("Введите одно число (или stop): ");
    answer = Console.ReadLine();
    if (answer == "stop") Console.Write($"Чисел больше 0 было введено - {count}, всего было введено - {nums}");
    else
    {
    double x = Convert.ToDouble(answer);
        nums++;
        if (x > 0) count++;
    }
}
*/


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
double DotX (double B1, double K1, double B2, double K2)
{
    double tx = (B2 - B1) / (K1 - K2);
    return tx;
}

double DotY (double B1, double K1, double B2, double K2, double X)
{
    double ty = K1 * X + B1;
    return ty;
}

Console.Write("Значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double dX = DotX(b1, k1, b2, k2);
double dY = DotY(b1, k1, b2, k2, dX);

Console.Write($"Точка пересечения прямых ({dX}, {dY})");
*/





// Не актуально
/*
Console.Write("Значение k1: ");
string stop = Console.ReadLine();
if (stop == "stop") Console.Write("- stop -");
else
{
double k1 = Convert.ToDouble(stop);
Console.Write(k1);
}
*/