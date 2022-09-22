// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int AckermanFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         n = n + 1;
//         return n;
//     }
//     if (m > 0 && n == 0)
//     {
//         return AckermanFunction(m - 1, 1);
//     }
//     else
//     {
//         return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
//     }
// }

// int m = new Random().Next(1,10);
// int n = new Random().Next(1,10);
// Console.WriteLine($"даны числа m: {m} и n: {n}");

// int result = AckermanFunction(m, n);
// Console.WriteLine($"Функция Аккермана при А({m},{n}) = {result}");


int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}
int m = new Random().Next(1,5);
int n = new Random().Next(1,5);
Console.WriteLine($"даны числа m: {m} и n: {n}");

int result = AkkermanFunction(m, n);
Console.WriteLine($"Функция Аккермана при А({m},{n}) = {result}");
