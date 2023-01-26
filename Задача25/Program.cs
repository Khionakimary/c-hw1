// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getUserData(string message) 
{ 
    Console.WriteLine(message); 
    int number = int.Parse(Console.ReadLine()!); 
    return number; 
} 
int getNumberExponentiation(int numberA, int numberB) 
{ 
    int sum = 1; 
    for (int i = 1; i <= numberB; i++) 
    { 
        sum = sum * numberA; 
    } 
    return sum; 
} 
int numberA = getUserData("Введите число A"); 
int numberB = getUserData("Введите число B"); 
int sum = getNumberExponentiation(numberA, numberB); 
Console.WriteLine($"Произведение возведения числа А в натуральную степень B равен {sum}");
