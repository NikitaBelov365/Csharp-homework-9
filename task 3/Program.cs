// Задача 3: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int n, int m)
{    
    if (n == 0) return m + 1;
    if (n !=0 && m == 0) return A(n-1, 1);
    else return A(n-1, A(n, m-1));
}


int n = InputInt("Input n");
int m = InputInt("Input m");

int result = A(n, m);
System.Console.WriteLine(result);