﻿/*Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
Console.Clear();
int m = InputNumbers("Введите число m: ");
int n = InputNumbers("Введите число n: ");
int functionAckermann = Ackermann(m, n);
Console.Write($"Функция Аккермана = {functionAckermann} ");
