// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void NaturalNumberSum(int N1,int N2,int Sum)
{
    if (N1 == N2)
    {
        Sum = Sum + N1;
        Console.WriteLine($" {Sum}");
        return;
    }
    if (N1 < N2)
    {
        Sum = Sum + N1;
        NaturalNumberSum(N1 + 1, N2, Sum);
    }
}



int M = new Random().Next(1,50);
int N = new Random().Next(50,100);
Console.WriteLine("даны числа M: "+M+" и N: "+N);
Console.Write($"сумма натуральных числе от {M} до {N}:");
int Sum = 0;
NaturalNumberSum(M, N, Sum);

