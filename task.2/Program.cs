// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void result(double x)
{
    for (int i = 1; i <= x; i++)
{
    double result1 = Math.Pow(i, 3);    
    Console.WriteLine(result1);
}
}

int N = ReadInt("ВВедите число - >");
result(N);