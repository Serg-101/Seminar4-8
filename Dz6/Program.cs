/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
 */

int GetNumber(string message)
{
    Console.Write(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int a))
            if (a >= 0)
                return a;
            else
                System.Console.WriteLine("ошибка 002 ! Введите не отрицательное число.");
        else
            System.Console.WriteLine("ошибка 001 ! Введите положительное число.");
    }
}

int Akkerman(int m, int n)
{
    return n = (m == 0) ? n + 1 : (m > 0 && n == 0) ? Akkerman(m - 1, 1) : Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
int m = GetNumber("Введите чило М = ");
int n = GetNumber("Введите чило N = ");
int resultAkkerman = Akkerman(m, n);
Console.WriteLine($"{resultAkkerman} результат");

