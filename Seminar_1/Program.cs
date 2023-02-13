// int num = -12;
// double bigNum = 12.13;
// bool isEven = true;
// string word = "flower";
// char symbol = '$';

/*
int num1 = -12;
int num2 = 6;

Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");
*/
// ReadLine - получение данных от пользователя, !!!всегда!!! используется эта команда.

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is " + num);

// Work1
/* Task 1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.*/

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.Write("Yes!");
}
else
{
    Console.Write("No!");
}
*/

// Work2
/* Task 2. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.*/

/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// 31542 / 10 = 3154
// 31542 / 100 = 315
// 31542 / 1000 = 31
// 31542 / 10000 = 3

// 31542 % 10 = 2
// 31542 % 100 = 42
// 31542 % 1000 = 542
// 31542 % 10000 = 1542

// 453216 -> 32

// 453216 / 100 = 4532
// 4532 % 100 = 32