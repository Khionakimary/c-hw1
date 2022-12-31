// Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int ShowSecondDigit(int number)
{
    int digit3 = number % 100;
    int digit1 = number % 10;
    int result = (digit3 - digit1) / 10;
    return result;
}
int threedigitNumber = number;
int SecondDigit = ShowSecondDigit (threedigitNumber);
Console.WriteLine($"Число {threedigitNumber} - его вторая цифра {SecondDigit}");