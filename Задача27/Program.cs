// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getUserDate(string message) 
{ 
    Console.WriteLine(message); 
    int userData = int.Parse(Console.ReadLine()!); 
    return userData; 
} 
int getDigitSum(int number) 
{ 
    int sum = 0; 
    while (number > 0) 
    { 
        sum = sum + number % 10; 
        number = number / 10; 
    } 
    return sum; 
} 
void showResult (string messageStart, int data) 
{ 
    Console.Write(messageStart); 
    Console.Write(data); 
     
}  
int number = getUserDate("Введите число"); 
int sum = getDigitSum(number); 
showResult($"Сумма цифр в числе {number} = ", sum);

