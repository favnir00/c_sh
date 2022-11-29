//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Clear();
Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1 > n2)
{
Console.WriteLine("First number is greater than second");
}
else if (n1 < n2)
{
Console.WriteLine("Second number is greater than first");
}
else
{
Console.WriteLine("First number is equal to second");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();
Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
if(n1 > n2 && n1 > n3)
{
Console.WriteLine("First number is greater");
}
else if (n2 > n1 && n2 > n3)
{
Console.WriteLine("Second number is greater");
}
else if (n3 > n1 && n3 > n2)
{
Console.WriteLine("Third number is greater");
}
else
{
Console.WriteLine("Some numbers are equal, use differnt numbers");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2 == 1)
{
Console.WriteLine("Odd");
}
else if (n%2 == 0)
{
Console.WriteLine("Even");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 0)
{
    for ( int i = 1; i <= n; i++)
    {
        if (i%2 == 0) Console.WriteLine(i);
    }
} else
{
    for ( int i = n; i <= -1; i++)
    {
        if (i%2 == 0) Console.WriteLine(i);
    }
}
*/

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n%10;
int n3 = n/100;
Console.Write($"{(n - 100 * n3 - n1)/10}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int n1 = -1;
int n2 = -1;
int n3 = -1;
if (n < 0) {
    n = -n;
}
while (n / i*10 > 1) {
n3 = n2;
n2 = n1;
n1 = n/i;
i = i*10;
}
if (n3 == -1) {
Console.Write("There is no third numder");
}
else
Console.Write($"Third number is {n3%10}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
{
Console.Write("Weekend");
} else
{
Console.Write("Workday");
}
*/

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10000;
int n2 = (n - n1*10000)/1000;
int n3 = (n - n1*10000 - n2*1000)/100;
int n4 = (n - n1*10000 - n2*1000 - n3*100)/10;
int n5 = n%10;

if (n1 == n5 && n2 == n4)
{
Console.WriteLine("Yes");
} else
{
Console.WriteLine("No");
}
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();
Console.Write("Enter XA coordinate: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter XB coordinate: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter YA coordinate: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter YB coordinate: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ZA coordinate: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ZB coordinate: ");
int zb = Convert.ToInt32(Console.ReadLine());
double l = Math.Sqrt((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb) + (za-zb)*(za-zb));
Console.Write($"Length {l}");
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (n >= i) {
Console.Write($"{i*i*i}, ");
i++;
}
*/
