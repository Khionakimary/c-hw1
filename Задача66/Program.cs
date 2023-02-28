/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getUserMessage(string message)
{
    Console.WriteLine(message);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int GetCalculateSumOfGapBetweenNum(int numberN, int numberM)
       { 
            if(numberN > numberM)  return 0;
            
            return numberN + GetCalculateSumOfGapBetweenNum(numberN + 1, numberM); 
       }
       
int numberN = getUserMessage("Введите число M ");
int numberM = getUserMessage("Введите число N ");
int result = GetCalculateSumOfGapBetweenNum(numberN,numberM);		
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberN } до {numberM} равна {result}");
