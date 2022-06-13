/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/
void NaturalNumbersN(int numberM, int numberN)
{
    if (numberN > numberM)
    {
        //Console.Write("Эту часть за час реализовать без зависания не получилось :( сорри");
        return;
    }
    else
    {
        Console.Write(numberM);
        if (numberM > numberN)
        {
            Console.Write(", ");
        }

        NaturalNumbersN(numberM - 1, numberN);
    }
}
Console.WriteLine("Введите число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumbersN(M, N);