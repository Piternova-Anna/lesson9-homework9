// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalNumber(int N1, int N2)
{
    if (N1 == N2)
    {
        Console.WriteLine($" {N1}");
        return;
    }
    if (N1 < N2)
    {
        Console.Write($" {N1},");
        NaturalNumber(N1 + 1, N2);
    }
}

int M = new Random().Next(1,100);
int N = new Random().Next(1,100);
Console.WriteLine("даны числа M: "+M+" и N: "+N);
if (M < N)
{
    Console.Write($"Натуральные числа от {M} до {N}:");
    NaturalNumber(M, N);
}
else
{
    Console.WriteLine("M должно быть меньше N");
}
