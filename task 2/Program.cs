// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int RecSum(int m, int n)
{
    if (m == n+1 ) return 0;
    return m + RecSum(m+1, n);
}




int m = InputInt("Input minimum");
int n = InputInt("Input maximum");

int totalSum = RecSum(m, n);
System.Console.WriteLine($"Sum of all natural numbers between {m} and {n} is equal {totalSum}");