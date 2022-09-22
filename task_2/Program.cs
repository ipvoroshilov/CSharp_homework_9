// ##Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumbersFromTo (int M, int N)
{
    if (M > N) return 0;
    //int sum = sum + M;
    return M + SumOfNumbersFromTo (M+1, N);
}
try
{
    Console.Write("Введите начальное число: \t");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число: \t");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма чисел равна: \t\t" + SumOfNumbersFromTo (M, N));
}
catch
{
    Console.Write("error");
}