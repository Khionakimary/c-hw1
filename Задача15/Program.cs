// Программа, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным.

Console.WriteLine("введите цифру: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1)
{
    Console.Write("понедельник - не выходной");
}
else if (number == 2)
{
    Console.Write("вторник - не выходной");
}
else if (number == 3)
{
    Console.Write("среда - не выходной");
}
else if (number == 4)
{
    Console.Write("четверг - не выходной");
}
else if (number == 5)
{
    Console.Write("пятница - не выходной");
}
else if (number == 6)
{
    Console.Write("суббота - выходной");
}
else if (number == 7)
{
    Console.Write("воскресенье - выходной");
}
else
{
    Console.Write("введите другое число");
}