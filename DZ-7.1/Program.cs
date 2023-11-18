/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

SumMandN(M, N);
void SumMandN(int M, int N)

{
    Console.WriteLine(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int result = M;
    if (M == N)
    return 0;
    else
    {
        M++;
        result = M + SumMN(M,N);
        return result;
    }
}