// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int RecSum(int m, int n, int sum)
{
    if (m == n - 1) return sum;
    m +=1;
    return sum += m + RecSum(m, n, sum);
}




int m = InputInt("Input minimum");
int n = InputInt("Input maximum");
int sum = 0;
int totalSum = RecSum(m, n, sum);
System.Console.WriteLine($"Sum of all natural numbers between {m} and {n} is equal {totalSum}");