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