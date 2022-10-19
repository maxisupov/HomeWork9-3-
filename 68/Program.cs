//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите чило M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите чило N: ");
int n = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Функция Аккермана чисел {m} и {n} = {FunctionAkkerman(m, n)} ");

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}