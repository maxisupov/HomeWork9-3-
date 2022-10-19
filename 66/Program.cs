// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите чило M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите чило N: ");
int n = int.Parse(Console.ReadLine()!);

void SumNumbers (int m, int n, int sum)
{
    if(m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
        return;
    } 
    sum = sum + (m++);
    SumNumbers(m, n, sum);
}

SumNumbers(m, n, 0);

