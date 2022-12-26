// Программа, которая на вход принимает два числа и выдает какое больше, а какое меньшее

Console.WriteLine("введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine()!);

int max = firstnumber;

if (firstnumber < secondnumber) max = secondnumber;
{
    Console.Write("max = ");
    Console.WriteLine(max);
}
