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

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();
Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for (int i = 1; i <= n2; i++)
   pow = pow * n1;
Console.Write($"n1 pow n2 = {pow}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n >= 1) {
sum = sum + n%10;
n = n/10;
}
Console.Write($"Summ = {sum}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++) {
  Console.Write($"Enter {i} number of array: ");
  array[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", array));
*/

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Clear();
Console.Write("Enter lenth of array: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
for (int i = 0; i < array.Length; i++)
  array[i]= new Random().Next(100, 1000);
Console.WriteLine(string.Join(", ", array));
CountEvenArray(array);

void CountEvenArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]%2 == 0) {
        count++;
        }
    }
    Console.WriteLine($"Quantity = {count}");
}
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Clear();
Console.Write("Enter lenth of array: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
for (int i = 0; i < array.Length; i++)
  array[i]= new Random().Next(1, 100);
Console.WriteLine(string.Join(", ", array));
SumOddPosArray(array);

void SumOddPosArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2){
        sum = sum + array[i];
    }
    Console.WriteLine($"Sum = {sum}");
}
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Clear();
Console.Write("Enter lenth of array: ");
int l = Convert.ToInt32(Console.ReadLine());
double[] array = new double[l];
for (int i = 0; i < array.Length; i++)
  array[i]= new Random().NextDouble()*(50-10)+10;
Console.WriteLine(string.Join(", ", array));
DiffMinMaxArray(array);

void DiffMinMaxArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max)
          max = array[i];
        if (array[i] < min)
          min = array[i];
        diff = max - min;
    }
    Console.WriteLine($"Difference = {diff}");
}
*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Clear();
Console.Write("Enter quantity of numbers: ");
int l = Convert.ToInt32(Console.ReadLine());
int count = 0;
int n = 0;
for (int i = 1; i < l + 1; i++) {
  Console.WriteLine($"Enter {i} number: ");
  n = Convert.ToInt32(Console.ReadLine());
  if (n > 0 ) count += 1;
}
Console.WriteLine($"Quantity of positive numbers is {count}");
*/

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Clear();
Console.Write("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
LineCross(k1, b1, k2, b2);

void LineCross(int fk1, int fb1, int fk2, int fb2)
{
    int x = (fb2 - fb1)/(fk1 - fk2);
    int y = fk1*x + fb1;
    Console.WriteLine($"Intersection point is {x}, {y}");
}
*/

//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void InputMatrix(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble();
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Input m and n: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
double[,] matrix = new double[row, column];
InputMatrix(matrix);
*/

//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void randomMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void findElement(int m, int n, int[, ] matrix)
{
    if (m>matrix.GetLength(0) || n>matrix.GetLength(1))
    {
      Console.Write("No such element");
    }
    else
      Console.Write($"Your element is: {matrix[m-1, n-1]}");
}

Console.Clear();
Console.Write("Input position of element: ");
string[] coord = Console.ReadLine().Split(" ");
int rowPosition = int.Parse(coord[0]);
int columnPosition = int.Parse(coord[1]);
int[,] matrix = new int[5, 5];
randomMatrix(matrix);
findElement(rowPosition, columnPosition, matrix);
*/

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void randomMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

void findMean(int[, ] matrix)
{
    double mean = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        mean = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            mean = mean + matrix[i, j];
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine($"\t {i+1} row mean is: {mean/matrix.GetLength(1)}");
    }
}

Console.Clear();
Console.Write("Input matrix size: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
randomMatrix(matrix);
findMean(matrix);
*/
