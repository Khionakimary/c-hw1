// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("введите число: ");
int a = 1;
int b = int.Parse(Console.ReadLine()!);

while (a <=b)
{
    if (a%2 ==0)
    {
        Console.WriteLine(a+" ");
    }
a++;
}
