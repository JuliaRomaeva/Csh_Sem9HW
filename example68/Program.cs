// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());

int Acc(int M, int N)
{
    if (M == 0)
        return N + 1;
    else
    if ((M != 0) && (N == 0))
        return Acc(M - 1, 1);
    else
        return Acc(M - 1, Acc(M, N - 1));
}
WriteLine($"m = {m}; n = {n} -> A(m,n) = {Acc(m, n)}");