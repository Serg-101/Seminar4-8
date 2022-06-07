/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Summ(int m, int n)
{
    return m += (m < n) ? Summ(++m, n) : 0;
}

Console.Clear();
System.Console.WriteLine("Сумма натуральных чисел в промежутке от M до N");
System.Console.Write("Введите число M = ");
int numM = int.Parse(Console.ReadLine());
System.Console.Write("Введите число N = ");
int numN = int.Parse(Console.ReadLine());
int summ = Summ(numM, numN);
Console.WriteLine($"M = {numM}; N = {numN}; ->  {summ} сумма");
