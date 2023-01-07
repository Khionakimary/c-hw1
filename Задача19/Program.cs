// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int digit1 = number / 10000;
int digit5 = number % 10;
int digit4 = number % 100 / 10;
int digit2 = number % 10000 / 1000;

if (digit1 / digit5 == 1 && digit2 / digit4 == 1)
{
    Console.WriteLine("число палиндром");
}
else 
{
    Console.WriteLine("число не палиндром");
}
