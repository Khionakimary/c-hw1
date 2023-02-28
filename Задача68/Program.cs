/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int getUserMessage(string message)
{
    Console.WriteLine(message);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int CalculateAkkermanFunction(int m, int n)
	{
		if(m == 0)
			{
				return n + 1;
			}
		if(m > 0 && n == 0)
			{
				return CalculateAkkermanFunction(m - 1, 1);
			}
		return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
	}
int numberN = getUserMessage("Введите число m ");
int numberM = getUserMessage("Введите число n ");
int result = CalculateAkkermanFunction(numberN,numberM);		
Console.WriteLine($"Сумма вычисления функции Аккермана с помощью рекурсии для чисел {numberN} и {numberM} = {result}");
