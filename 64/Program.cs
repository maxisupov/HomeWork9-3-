// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите чило N: ");
int M = int.Parse(Console.ReadLine()!);

string Recurs(int m, int n)
{
    if( m == n)
    {
        return m.ToString();
    }
    return(m + " " + Recurs(m - 1, n));
}

Console.WriteLine(Recurs(M, 1));



    
