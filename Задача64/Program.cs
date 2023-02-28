/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int getUserMessage(string message)
{
    Console.WriteLine(message);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
void PrintOfNumbersFromNToOne(int num)  
    { 
        if (num == 0) return;

        Console.Write($"{num} ");

        PrintOfNumbersFromNToOne(num - 1);  
    } 
  
int N = getUserMessage("Введите число N ");
PrintOfNumbersFromNToOne(N);
