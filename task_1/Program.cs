// ##Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string PrintNumbersFromTo(int M, int N)
{
    if (M == N) return $"{N}.";
    return  $"{M}" + ", " + PrintNumbersFromTo (M + 1, N);
}
try
{
    Console.Write("Введите начальное число: \t");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число: \t");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(PrintNumbersFromTo(M, N));}
catch
{
    Console.WriteLine("error");
}
