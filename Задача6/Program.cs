// Программа, которая на вход принимает число и выдает, является ли число четным (делится на 2 без остатка).

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2 == 0)

{
    Console.WriteLine("да");

}
else
{
    Console.WriteLine("нет");
}