// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMtoN(int m, int n)
{
    if (m > n)
        return SumFromMtoN(m - 1, n) + m;
    else if (m < n) return SumFromMtoN(n - 1, m) + n;
    else return m;
}
Console.WriteLine("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) Console.WriteLine("Sum of elements from n to m are: ");
else Console.WriteLine("Sum of elements from m to n is: ");
Console.WriteLine(SumFromMtoN(m, n));