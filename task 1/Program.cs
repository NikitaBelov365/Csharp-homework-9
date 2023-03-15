// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке 
// от M до N с помощью рекурсии.

string RecNatur(int m, int n)
{
    if (m %2 != 0) m += 1;
    if (m >= n-1) return $"{m}";
    return $"{m} " + RecNatur(m + 2, n);
}

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int m = InputInt("Input minimum");
int n = InputInt("Input maximum");

System.Console.Write(RecNatur(m, n));