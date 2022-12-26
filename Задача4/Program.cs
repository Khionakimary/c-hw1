// Программа, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье число: ");
int thirdnumber = int.Parse(Console.ReadLine()!);

int max = firstnumber;

if (firstnumber < secondnumber) max = secondnumber;
if (secondnumber < thirdnumber) max = thirdnumber;
if (thirdnumber < firstnumber) max = firstnumber;

Console.Write ("max = ");
Console.WriteLine(max);