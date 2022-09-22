// ##Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int AckermanRecursion(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanRecursion(m - 1, 1);
    else return AckermanRecursion(m - 1, AckermanRecursion(m, n - 1));
}
try
{
Console.WriteLine("Ввведите первое неотрицательное число: /t");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе неотрицательное число: /t");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermanRecursion(m, n));
}
catch
{
    Console.WriteLine("error");
}